namespace WinFormsLibrary1
{
    public class ExternalClass : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize((object) this);
            GC.KeepAlive((object)this);
        }
    }
}
