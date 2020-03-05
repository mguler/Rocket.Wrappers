using Rocket.Wrappers.Abstract.Net;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Rocket.Wrappers.Impl.Net
{
    public class SocketWrapper:ISocketWrapper
    {
        private readonly Socket _socket;
        public virtual int Available { get=>_socket.Available; }
        public virtual EndPoint LocalEndPoint { get=>_socket.LocalEndPoint; }
        public virtual EndPoint RemoteEndPoint { get=>_socket.RemoteEndPoint; }
        public virtual IntPtr Handle { get=>_socket.Handle; }
        public virtual bool Blocking { get => _socket.Blocking; set => _socket.Blocking = value; }
        public virtual bool UseOnlyOverlappedIO { get => _socket.UseOnlyOverlappedIO; set => _socket.UseOnlyOverlappedIO = value; }
        public virtual bool Connected { get=>_socket.Connected; }
        public virtual AddressFamily AddressFamily { get=>_socket.AddressFamily; }
        public virtual ProtocolType ProtocolType { get=>_socket.ProtocolType; }
        public virtual bool IsBound { get => _socket.IsBound; }
        public virtual bool ExclusiveAddressUse { get => _socket.ExclusiveAddressUse; set => _socket.ExclusiveAddressUse = value; }
        public virtual int ReceiveBufferSize { get => _socket.ReceiveBufferSize; set => _socket.ReceiveBufferSize = value; }
        public virtual int SendBufferSize { get => _socket.SendBufferSize; set => _socket.SendBufferSize = value; }
        public virtual int ReceiveTimeout { get => _socket.ReceiveTimeout; set => _socket.ReceiveTimeout = value; }
        public virtual int SendTimeout { get => _socket.SendTimeout; set => _socket.SendTimeout = value; }
        public virtual LingerOption LingerState { get => _socket.LingerState; set => _socket.LingerState = value; }
        public virtual bool NoDelay { get => _socket.NoDelay; set => _socket.NoDelay = value; }
        public virtual short Ttl { get => _socket.Ttl; set => _socket.Ttl = value; }
        public virtual bool DontFragment { get => _socket.DontFragment; set => _socket.DontFragment = value; }
        public virtual bool MulticastLoopback { get => _socket.MulticastLoopback; set => _socket.MulticastLoopback = value; }
        public virtual SocketType SocketType { get=>_socket.SocketType; }
        public virtual bool EnableBroadcast { get => _socket.EnableBroadcast; set => _socket.EnableBroadcast = value; }
        public virtual bool DualMode { get; set; }
        public virtual Socket Accept() => _socket.Accept();
        public virtual bool AcceptAsync(SocketAsyncEventArgs e) => _socket.AcceptAsync(e);
        public virtual IAsyncResult BeginAccept(Socket acceptSocket, int receiveSize, AsyncCallback callback, object state)=>_socket.BeginAccept(acceptSocket, receiveSize, callback, state);
        public virtual IAsyncResult BeginAccept(int receiveSize, AsyncCallback callback, object state)=>_socket.BeginAccept(receiveSize, callback, state);
        public virtual IAsyncResult BeginAccept(AsyncCallback callback, object state)=>_socket.BeginAccept(callback, state);
        public virtual IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) => _socket.BeginConnect(remoteEP, callback, state);
        public virtual IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)=>_socket.BeginConnect(address, port, requestCallback, state);
        public virtual IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)=>_socket.BeginConnect(host,port, requestCallback, state);
        public virtual IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)=>_socket.BeginConnect(addresses, port, requestCallback, state);
        public virtual IAsyncResult BeginDisconnect(bool reuseSocket, AsyncCallback callback, object state)=>_socket.BeginDisconnect(reuseSocket, callback, state);
        public virtual IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state)=>_socket.BeginReceive(buffers, socketFlags, callback, state);
        public virtual IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)=> BeginReceive(buffer, offset, size, socketFlags, callback, state);
        public virtual IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)=>_socket.BeginReceive(buffer, offset, size, socketFlags, out errorCode, callback, state);
        public virtual IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)=>_socket.BeginReceive(buffers, socketFlags, out errorCode, callback, state);
        public virtual IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)=>_socket.BeginReceiveFrom(buffer, offset, size, socketFlags, ref remoteEP, callback, state);
        public virtual IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)=>_socket.BeginReceiveMessageFrom(buffer, offset, size, socketFlags, ref remoteEP, callback, state);
        public virtual IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) => _socket.BeginSend(buffer, offset, size, socketFlags, out errorCode, callback, state);
        public virtual IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)=>_socket.BeginSend(buffer, offset, size, socketFlags, callback, state);
        public virtual IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) => _socket.BeginSend(buffers, socketFlags, out errorCode, callback, state);
        public virtual IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state)=>_socket.BeginSend(buffers, socketFlags, callback, state);
        public virtual IAsyncResult BeginSendFile(string fileName, AsyncCallback callback, object state)=>_socket.BeginSendFile(fileName, callback, state);
        public virtual IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, AsyncCallback callback, object state) => _socket.BeginSendFile(fileName, preBuffer, postBuffer, flags, callback, state);
        public virtual IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) => _socket.BeginSendTo(buffer, offset, size, socketFlags, remoteEP, callback, state);
        public virtual void Bind(EndPoint localEP)=>_socket.Bind(localEP);
        public virtual void Close(int timeout)=>_socket.Close(timeout);
        public virtual void Close()=>_socket.Close();
        public virtual void Connect(EndPoint remoteEP)=>_socket.Connect(remoteEP);
        public virtual void Connect(IPAddress address, int port)=>_socket.Connect(address, port);
        public virtual void Connect(string host, int port)=>_socket.Connect(host, port);
        public virtual void Connect(IPAddress[] addresses, int port) => _socket.Connect(addresses, port);
        public virtual bool ConnectAsync(SocketAsyncEventArgs e)=>_socket.ConnectAsync(e);
        public virtual void Disconnect(bool reuseSocket)=>_socket.Disconnect(reuseSocket);
        public virtual bool DisconnectAsync(SocketAsyncEventArgs e)=>_socket.DisconnectAsync(e);
        public virtual SocketInformation DuplicateAndClose(int targetProcessId)=>_socket.DuplicateAndClose(targetProcessId);
        public virtual Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) => _socket.EndAccept(out buffer, out bytesTransferred, asyncResult);
        public virtual Socket EndAccept(out byte[] buffer, IAsyncResult asyncResult)=>_socket.EndAccept(out buffer, asyncResult);
        public virtual Socket EndAccept(IAsyncResult asyncResult)=>_socket.EndAccept(asyncResult);
        public virtual void EndConnect(IAsyncResult asyncResult)=>_socket.EndConnect(asyncResult);
        public virtual void EndDisconnect(IAsyncResult asyncResult)=>_socket.EndDisconnect(asyncResult);
        public virtual int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)=>_socket.EndReceive(asyncResult, out errorCode);
        public virtual int EndReceive(IAsyncResult asyncResult)=>_socket.EndReceive(asyncResult);
        public virtual int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)=>_socket.EndReceiveFrom(asyncResult, ref endPoint);
        public virtual int EndReceiveMessageFrom(IAsyncResult asyncResult, ref SocketFlags socketFlags, ref EndPoint endPoint, out IPPacketInformation ipPacketInformation) => _socket.EndReceiveMessageFrom(asyncResult, ref socketFlags, ref endPoint, out ipPacketInformation);
        public virtual int EndSend(IAsyncResult asyncResult)=> _socket.EndSend(asyncResult);
        public virtual int EndSend(IAsyncResult asyncResult, out SocketError errorCode) => _socket.EndSend(asyncResult, out errorCode);
        public virtual void EndSendFile(IAsyncResult asyncResult)=> _socket.EndSendFile(asyncResult);
        public virtual int EndSendTo(IAsyncResult asyncResult)=>_socket.EndSendTo(asyncResult);
        public virtual byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength) => _socket.GetSocketOption(optionLevel, optionName, optionLength);
        public virtual object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)=>_socket.GetSocketOption(optionLevel, optionName);
        public virtual void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue) => _socket.GetSocketOption(optionLevel, optionName, optionValue);
        public virtual int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) => _socket.IOControl(ioControlCode, optionInValue, optionOutValue);
        public virtual int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) => _socket.IOControl(ioControlCode, optionInValue,  optionOutValue);
        public virtual void Listen(int backlog)=>_socket.Listen(backlog);
        public virtual bool Poll(int microSeconds, SelectMode mode)=>_socket.Poll(microSeconds, mode);
        public virtual int Receive(byte[] buffer, SocketFlags socketFlags)=>_socket.Receive(buffer, socketFlags);
        public virtual int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) => _socket.Receive(buffers, socketFlags, out errorCode);
        public virtual int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)=>_socket.Receive(buffers, socketFlags);
        public virtual int Receive(byte[] buffer, int size, SocketFlags socketFlags) => _socket.Receive(buffer, size, socketFlags);
        public virtual int Receive(IList<ArraySegment<byte>> buffers)=>_socket.Receive(buffers);
        public virtual int Receive(byte[] buffer)=>_socket.Receive(buffer);
        public virtual int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)=>_socket.Receive(buffer, offset, size, socketFlags);
        public virtual int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)=>_socket.Receive(buffer, offset, size, socketFlags, out errorCode);
        public virtual bool ReceiveAsync(SocketAsyncEventArgs e)=>_socket.ReceiveAsync(e);
        public virtual int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP)=>_socket.ReceiveFrom(buffer, ref remoteEP);
        public virtual int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP)=>_socket.ReceiveFrom( buffer, socketFlags, ref remoteEP);
        public virtual int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP)=>_socket.ReceiveFrom(buffer, size, socketFlags, ref remoteEP);
        public virtual int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP)=>_socket.ReceiveFrom(buffer, offset, size, socketFlags, ref remoteEP);
        public virtual bool ReceiveFromAsync(SocketAsyncEventArgs e)=>_socket.ReceiveFromAsync(e);
        public virtual int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation)=>_socket.ReceiveMessageFrom(buffer, offset, size, ref socketFlags, ref remoteEP, out ipPacketInformation);
        public virtual bool ReceiveMessageFromAsync(SocketAsyncEventArgs e) => _socket.ReceiveMessageFromAsync(e);
        public virtual int Send(byte[] buffer)=>_socket.Send(buffer);
        public virtual int Send(byte[] buffer, int size, SocketFlags socketFlags) => _socket.Send(buffer, size, socketFlags);
        public virtual int Send(byte[] buffer, SocketFlags socketFlags) => _socket.Send(buffer, socketFlags);
        public virtual int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) => _socket.Send(buffer, offset, size, socketFlags, out errorCode);
        public virtual int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) => _socket.Send(buffer, offset, size, socketFlags);
        public virtual int Send(IList<ArraySegment<byte>> buffers) => _socket.Send(buffers);
        public virtual int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) => _socket.Send(buffers, socketFlags, out errorCode);
        public virtual int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) => _socket.Send(buffers, socketFlags);
        public virtual bool SendAsync(SocketAsyncEventArgs e) => _socket.SendAsync(e);
        public virtual void SendFile(string fileName) => _socket.SendFile(fileName);
        public virtual void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags)=>_socket.SendFile(fileName, preBuffer, postBuffer, flags);
        public virtual bool SendPacketsAsync(SocketAsyncEventArgs e) => _socket.SendPacketsAsync(e);
        public virtual int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) => _socket.SendTo(buffer, offset, size, socketFlags, remoteEP);
        public virtual int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP) => _socket.SendTo(buffer, size, socketFlags, remoteEP);
        public virtual int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP) => _socket.SendTo(buffer, socketFlags, remoteEP);
        public virtual int SendTo(byte[] buffer, EndPoint remoteEP) => _socket.SendTo(buffer, remoteEP);
        public virtual bool SendToAsync(SocketAsyncEventArgs e) => _socket.SendToAsync(e);
        public virtual void SetIPProtectionLevel(IPProtectionLevel level) => _socket.SetIPProtectionLevel(level);
        public virtual void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) => _socket.SetSocketOption(optionLevel, optionName, optionValue);
        public virtual void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue) => _socket.SetSocketOption(optionLevel, optionName, optionValue);
        public virtual void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) => _socket.SetSocketOption(optionLevel, optionName, optionValue);
        public virtual void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue) => _socket.SetSocketOption(optionLevel, optionName, optionValue);
        public virtual void Shutdown(SocketShutdown how) => _socket.Shutdown(how);
        public void Dispose() => _socket.Dispose();
    }
}
