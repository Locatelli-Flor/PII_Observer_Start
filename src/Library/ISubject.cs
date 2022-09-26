namespace Observer
{
    public interface ISubject<T>
    {
        public void Subscribe(IObserver<T> observer);
        public void Unsubscribe(IObserver<T> observer);
    }
}