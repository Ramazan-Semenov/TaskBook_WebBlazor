namespace TaskBook_WebBlazor.GlobalEvents
{
    public delegate void MessageReceivedEventHandler(string message, object obj);
    public class GlobalEvent
    {

        public event MessageReceivedEventHandler MessageReceived;
        public static GlobalEvent Instance = new GlobalEvent();

        public void Send(string message, object obj)
        {
            MessageReceived?.Invoke(message, obj);

        }
    }
}
