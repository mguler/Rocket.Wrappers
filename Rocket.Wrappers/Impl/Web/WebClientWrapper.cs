using Rocket.Wrappers.Abstract.Web;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Wrappers.Impl.Web
{
    public class WebClientWrapper : IWebClientWrapper
    {
        private readonly WebClient _webClient;
        public virtual Encoding Encoding { get => _webClient.Encoding; set => _webClient.Encoding = value; }
        public virtual string BaseAddress { get => _webClient.BaseAddress; set => _webClient.BaseAddress = value; }
        public virtual ICredentials Credentials { get => _webClient.Credentials; set => _webClient.Credentials = value; }
        public virtual bool UseDefaultCredentials { get => _webClient.UseDefaultCredentials; set => _webClient.UseDefaultCredentials = value; }
        public virtual WebHeaderCollection Headers { get => _webClient.Headers; set => _webClient.Headers = value; }
        public virtual NameValueCollection QueryString { get => _webClient.QueryString; set => _webClient.QueryString = value; }
        public virtual WebHeaderCollection ResponseHeaders { get => _webClient.ResponseHeaders;  }
        public virtual IWebProxy Proxy { get => _webClient.Proxy; set => _webClient.Proxy = value; }
        public virtual RequestCachePolicy CachePolicy { get => _webClient.CachePolicy; set => _webClient.CachePolicy = value; }
        public virtual bool IsBusy { get => _webClient.IsBusy; }

        public virtual event OpenReadCompletedEventHandler OpenReadCompleted { add => _webClient.OpenReadCompleted += value;  remove => _webClient.OpenReadCompleted -= value;  }
        public virtual event OpenWriteCompletedEventHandler OpenWriteCompleted { add => _webClient.OpenWriteCompleted += value;  remove => _webClient.OpenWriteCompleted -= value; } 
        public virtual event DownloadStringCompletedEventHandler DownloadStringCompleted { add => _webClient.DownloadStringCompleted += value;  remove => _webClient.DownloadStringCompleted -= value; } 
        public virtual event DownloadDataCompletedEventHandler DownloadDataCompleted { add => _webClient.DownloadDataCompleted += value;  remove => _webClient.DownloadDataCompleted -= value; } 
        public virtual event AsyncCompletedEventHandler DownloadFileCompleted { add => _webClient.DownloadFileCompleted += value;  remove => _webClient.DownloadFileCompleted -= value; } 
        public virtual event UploadStringCompletedEventHandler UploadStringCompleted { add => _webClient.UploadStringCompleted += value;  remove => _webClient.UploadStringCompleted -= value; } 
        public virtual event UploadDataCompletedEventHandler UploadDataCompleted { add => _webClient.UploadDataCompleted += value;  remove => _webClient.UploadDataCompleted -= value; } 
        public virtual event UploadFileCompletedEventHandler UploadFileCompleted { add => _webClient.UploadFileCompleted += value; remove => _webClient.UploadFileCompleted -= value; } 
        public virtual event UploadValuesCompletedEventHandler UploadValuesCompleted { add => _webClient.UploadValuesCompleted += value;  remove => _webClient.UploadValuesCompleted -= value; } 
        public virtual event DownloadProgressChangedEventHandler DownloadProgressChanged { add => _webClient.DownloadProgressChanged += value;  remove => _webClient.DownloadProgressChanged -= value; } 
        public virtual event UploadProgressChangedEventHandler UploadProgressChanged { add => _webClient.UploadProgressChanged += value;  remove => _webClient.UploadProgressChanged -= value; } 

        public virtual void CancelAsync() => _webClient.CancelAsync();
        public virtual byte[] DownloadData(string address) => _webClient.DownloadData(address);
        public virtual byte[] DownloadData(Uri address) => _webClient.DownloadData(address);
        public virtual void DownloadDataAsync(Uri address, object userToken) => _webClient.DownloadDataAsync(address, userToken);
        public virtual void DownloadDataAsync(Uri address) => _webClient.DownloadDataAsync(address);
        public virtual Task<byte[]> DownloadDataTaskAsync(string address) => _webClient.DownloadDataTaskAsync(address);
        public virtual Task<byte[]> DownloadDataTaskAsync(Uri address) => _webClient.DownloadDataTaskAsync(address);
        public virtual void DownloadFile(string address, string fileName) => _webClient.DownloadFile(address, fileName);
        public virtual void DownloadFile(Uri address, string fileName) => _webClient.DownloadFile(address, fileName);
        public virtual void DownloadFileAsync(Uri address, string fileName, object userToken) => _webClient.DownloadFileAsync(address, fileName, userToken);
        public virtual void DownloadFileAsync(Uri address, string fileName) => _webClient.DownloadFileAsync(address, fileName);
        public virtual Task DownloadFileTaskAsync(string address, string fileName) => _webClient.DownloadFileTaskAsync(address, fileName);
        public virtual Task DownloadFileTaskAsync(Uri address, string fileName) => _webClient.DownloadFileTaskAsync(address, fileName);
        public virtual string DownloadString(Uri address) => _webClient.DownloadString(address);
        public virtual string DownloadString(string address) => _webClient.DownloadString(address);
        public virtual void DownloadStringAsync(Uri address) => _webClient.DownloadStringAsync(address);
        public virtual void DownloadStringAsync(Uri address, object userToken) => _webClient.DownloadStringAsync(address, userToken);
        public virtual Task<string> DownloadStringTaskAsync(string address) => _webClient.DownloadStringTaskAsync(address);
        public virtual Task<string> DownloadStringTaskAsync(Uri address) => _webClient.DownloadStringTaskAsync(address);
        public virtual Stream OpenRead(Uri address) => _webClient.OpenRead(address);
        public virtual Stream OpenRead(string address) => _webClient.OpenRead(address);
        public virtual void OpenReadAsync(Uri address, object userToken) => _webClient.OpenReadAsync(address, userToken);
        public virtual void OpenReadAsync(Uri address) => _webClient.OpenReadAsync(address);
        public virtual Task<Stream> OpenReadTaskAsync(string address) => _webClient.OpenReadTaskAsync(address);
        public virtual Task<Stream> OpenReadTaskAsync(Uri address) => _webClient.OpenReadTaskAsync(address);
        public virtual Stream OpenWrite(string address) => _webClient.OpenWrite(address);
        public virtual Stream OpenWrite(string address, string method) => _webClient.OpenWrite(address, method);
        public virtual Stream OpenWrite(Uri address, string method) => _webClient.OpenWrite(address, method);
        public virtual Stream OpenWrite(Uri address) => _webClient.OpenWrite(address);
        public virtual void OpenWriteAsync(Uri address, string method, object userToken) => _webClient.OpenWriteAsync(address, method, userToken);
        public virtual void OpenWriteAsync(Uri address) => _webClient.OpenWriteAsync(address);
        public virtual void OpenWriteAsync(Uri address, string method) => _webClient.OpenWriteAsync(address, method);
        public virtual Task<Stream> OpenWriteTaskAsync(Uri address) => _webClient.OpenWriteTaskAsync(address);
        public virtual Task<Stream> OpenWriteTaskAsync(Uri address, string method) => _webClient.OpenWriteTaskAsync(address, method);
        public virtual Task<Stream> OpenWriteTaskAsync(string address) => _webClient.OpenWriteTaskAsync(address);
        public virtual Task<Stream> OpenWriteTaskAsync(string address, string method) => _webClient.OpenWriteTaskAsync(address, method);
        public virtual byte[] UploadData(Uri address, string method, byte[] data) => _webClient.UploadData(address, method, data);
        public virtual byte[] UploadData(string address, string method, byte[] data) => _webClient.UploadData(address, method, data);

        public virtual byte[] UploadData(string address, byte[] data) => _webClient.UploadData(address, data);
        public virtual byte[] UploadData(Uri address, byte[] data) => _webClient.UploadData(address, data);

        public virtual void UploadDataAsync(Uri address, string method, byte[] data, object userToken) => _webClient.UploadDataAsync(address, method, data, userToken);
        public virtual void UploadDataAsync(Uri address, string method, byte[] data) => _webClient.UploadDataAsync(address, method, data);
        public virtual void UploadDataAsync(Uri address, byte[] data) => _webClient.UploadDataAsync(address, data);
        public virtual Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data) => _webClient.UploadDataTaskAsync(address, method, data);
        public virtual Task<byte[]> UploadDataTaskAsync(Uri address, byte[] data) => _webClient.UploadDataTaskAsync(address, data);
        public virtual Task<byte[]> UploadDataTaskAsync(string address, byte[] data) => _webClient.UploadDataTaskAsync(address, data);
        public virtual Task<byte[]> UploadDataTaskAsync(Uri address, string method, byte[] data) => _webClient.UploadDataTaskAsync(address, method, data);
        public virtual byte[] UploadFile(Uri address, string method, string fileName) => _webClient.UploadFile(address, method, fileName);
        public virtual byte[] UploadFile(string address, string method, string fileName) => _webClient.UploadFile(address, method, fileName);
        public virtual byte[] UploadFile(Uri address, string fileName) => _webClient.UploadFile(address, fileName);
        public virtual byte[] UploadFile(string address, string fileName) => _webClient.UploadFile(address, fileName);
        public virtual void UploadFileAsync(Uri address, string method, string fileName) => _webClient.UploadFileAsync(address, method, fileName);
        public virtual void UploadFileAsync(Uri address, string method, string fileName, object userToken) => _webClient.UploadFileAsync(address, method, fileName, userToken);
        public virtual void UploadFileAsync(Uri address, string fileName) => _webClient.UploadFileAsync(address, fileName);
        public virtual Task<byte[]> UploadFileTaskAsync(string address, string fileName) => _webClient.UploadFileTaskAsync(address, fileName);
        public virtual Task<byte[]> UploadFileTaskAsync(Uri address, string fileName) => _webClient.UploadFileTaskAsync(address, fileName);
        public virtual Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName) => _webClient.UploadFileTaskAsync(address, method, fileName);
        public virtual Task<byte[]> UploadFileTaskAsync(Uri address, string method, string fileName) => _webClient.UploadFileTaskAsync(address, method, fileName);
        public virtual string UploadString(string address, string data) => _webClient.UploadString(address, data);
        public virtual string UploadString(Uri address, string data) => _webClient.UploadString(address, data);
        public virtual string UploadString(string address, string method, string data) => _webClient.UploadString(address, method, data);
        public virtual string UploadString(Uri address, string method, string data) => _webClient.UploadString(address, method, data);
        public virtual void UploadStringAsync(Uri address, string method, string data, object userToken) => _webClient.UploadStringAsync(address, method, data, userToken);
        public virtual void UploadStringAsync(Uri address, string method, string data) => _webClient.UploadStringAsync(address, method, data);
        public virtual void UploadStringAsync(Uri address, string data) => _webClient.UploadStringAsync(address, data);
        public virtual Task<string> UploadStringTaskAsync(string address, string method, string data) => _webClient.UploadStringTaskAsync(address, method, data);
        public virtual Task<string> UploadStringTaskAsync(Uri address, string method, string data) => _webClient.UploadStringTaskAsync(address, method, data);
        public virtual Task<string> UploadStringTaskAsync(string address, string data) => _webClient.UploadStringTaskAsync(address, data);
        public virtual Task<string> UploadStringTaskAsync(Uri address, string data) => _webClient.UploadStringTaskAsync(address, data);
        public virtual byte[] UploadValues(Uri address, string method, NameValueCollection data) => _webClient.UploadValues(address, method, data);
        public virtual byte[] UploadValues(string address, NameValueCollection data) => _webClient.UploadValues(address, data);
        public virtual byte[] UploadValues(string address, string method, NameValueCollection data) => _webClient.UploadValues(address, method, data);
        public virtual byte[] UploadValues(Uri address, NameValueCollection data) => _webClient.UploadValues(address, data);
        public virtual void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken) => _webClient.UploadValuesAsync(address, method, data, userToken);
        public virtual void UploadValuesAsync(Uri address, NameValueCollection data) => _webClient.UploadValuesAsync(address, data);
        public virtual void UploadValuesAsync(Uri address, string method, NameValueCollection data) => _webClient.UploadValuesAsync(address, method, data);
        public virtual Task<byte[]> UploadValuesTaskAsync(Uri address, string method, NameValueCollection data) => _webClient.UploadValuesTaskAsync(address, method, data);
        public virtual Task<byte[]> UploadValuesTaskAsync(Uri address, NameValueCollection data) => _webClient.UploadValuesTaskAsync(address, data);
        public virtual Task<byte[]> UploadValuesTaskAsync(string address, string method, NameValueCollection data) => _webClient.UploadValuesTaskAsync(address, method, data);
        public virtual Task<byte[]> UploadValuesTaskAsync(string address, NameValueCollection data) => _webClient.UploadValuesTaskAsync(address, data);
        public void Dispose() => _webClient.Dispose();
        public WebClientWrapper(WebClient webClient)
        {
            _webClient = webClient;
        }
        public WebClientWrapper()
        {
            _webClient = new WebClient();
        }
    }
}
