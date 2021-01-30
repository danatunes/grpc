// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/chat.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ChatProject.Protos {
  public static partial class Chat
  {
    static readonly string __ServiceName = "Chat";

    static readonly grpc::Marshaller<global::ChatProject.Protos.Message> __Marshaller_Message = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ChatProject.Protos.Message.Parser.ParseFrom);

    static readonly grpc::Method<global::ChatProject.Protos.Message, global::ChatProject.Protos.Message> __Method_join = new grpc::Method<global::ChatProject.Protos.Message, global::ChatProject.Protos.Message>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "join",
        __Marshaller_Message,
        __Marshaller_Message);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ChatProject.Protos.ChatReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Chat</summary>
    [grpc::BindServiceMethod(typeof(Chat), "BindService")]
    public abstract partial class ChatBase
    {
      public virtual global::System.Threading.Tasks.Task join(grpc::IAsyncStreamReader<global::ChatProject.Protos.Message> requestStream, grpc::IServerStreamWriter<global::ChatProject.Protos.Message> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ChatBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_join, serviceImpl.join).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ChatBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_join, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::ChatProject.Protos.Message, global::ChatProject.Protos.Message>(serviceImpl.join));
    }

  }
}
#endregion
