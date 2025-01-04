using System.Collections.ObjectModel;

using TaskBook_WebBlazor.Entity;

namespace TaskBook_WebBlazor.ViewModel
{

    public class SingleTBVM
    {
        public static Task_Book_ViewModel Instance { get; private set; } = new Task_Book_ViewModel();



    }
    public class Task_Book_ViewModel
    {

        public async Task<Task_Book> Create_Task(Task_Book t)
        {
            _Task_Books.Add(t);
            Task_Books = _Task_Books.AsQueryable();
            return await Task.FromResult(t);
        }
        public async Task<Task_Book> Edit_Task(Task_Book? task)
        {
            var t = Task_Books.FirstOrDefault(x => x == task);


            return await Task.FromResult(t);
        }
        public async Task<Task_Book> Create_On_Task(Task_Book? task)
        {
            var t = Task_Books.FirstOrDefault(x => x == task);

            Task_Book book = (Task_Book)t?.Clone();


            return await Task.FromResult(book);
        }
        public async Task<bool> Delete_Task(Task_Book? task)
        {
            var t = Task_Books.FirstOrDefault(x => x == task);

            _Task_Books.Remove(t);
            Task_Books = _Task_Books.AsQueryable();


            return await Task.FromResult(true);
        }

        public IQueryable<Task_Book> Task_Books { get; set; }
        public ObservableCollection<Task_Book> _Task_Books { get; set; } = new ObservableCollection<Task_Book>();


        public Task_Book_ViewModel()
        {
            _Task_Books.Add(new Task_Book());
            _Task_Books.Add(new Task_Book());
            _Task_Books.Add(new Task_Book());
            Task_Books = _Task_Books.AsQueryable();
            _Task_Books.CollectionChanged += _Task_Books_CollectionChanged;
        }

        private void _Task_Books_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }
    }

}
