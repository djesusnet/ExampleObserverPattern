namespace ExampleObserverPattern.Interfaces
{
    public interface ISubject
    {
        void Anexar(IObserver observer);
        void Notificar();
    }
}
