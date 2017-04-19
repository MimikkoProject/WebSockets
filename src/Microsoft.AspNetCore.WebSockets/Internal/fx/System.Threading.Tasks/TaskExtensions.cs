using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System.Threading.Tasks
{

    internal static class TaskExtensions
    {

        public static Task ToTask(this Exception ex)
        {
            var tcs = new TaskCompletionSource<bool>();
            tcs.SetException(ex);
            return tcs.Task;
        }

        public static Task<TResult> ToTask<TResult>(this Exception ex)
        {
            var tcs = new TaskCompletionSource<TResult>();
            tcs.SetException(ex);
            return tcs.Task;
        }

    }

}