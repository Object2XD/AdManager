using System.Linq;

namespace System.Collections.Generic {
    public class ThreadQueue<T> {
        protected Queue<Queue<T>> queues = new Queue<Queue<T>>();

        public int Count {
            get { return queues.Count; }
        }

        public int CommitCount {
            get { return Math.Max(queues.Count - 1, 0); }
        }

        /// <summary>
        ///  
        /// </summary>
        public virtual void Commit() {
            lock (queues) {
                queues.Enqueue(new Queue<T>());
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item) {
            lock (queues) {
                if (queues.Count <= 0)
                    queues.Enqueue(new Queue<T>());
                queues.Last().Enqueue(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Queue<T> Dequeue() {
            lock (queues) {
                if (queues.Count <= 0)
                    return new Queue<T>();
                return queues.Dequeue();
            }
        }
    }
}