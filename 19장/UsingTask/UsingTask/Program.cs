using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcFile = args[0];

            Action<object> FileCopyAction = (object state) =>
            {
                String[] paths = (String[])state;
                File.Copy(paths[0], paths[1]);

                Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId,
                    paths[0], paths[1]);
            };

            // ┌─ 두번째 매개변수는 FileCopyAction의 매개 변수로 사용됩니다.
            Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });

            t1.Start();

            Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });

            t3.RunSynchronously();  // Task는 코드의 비동기 실행을 위한 Start() 메소드 뿐만 아니라 동기 실행을 위한 RunSynchronously 메소드도 제공합니다.

            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
