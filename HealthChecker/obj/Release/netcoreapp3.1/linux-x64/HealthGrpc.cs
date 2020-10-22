// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/health.proto
// </auto-generated>
// Original file comments:
// Copyright 2015 The gRPC Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The canonical version of this proto can be found at
// https://github.com/grpc/grpc-proto/blob/master/grpc/health/v1/health.proto
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Grpc.Health.V1 {
  public static partial class Health
  {
    static readonly string __ServiceName = "grpc.health.v1.Health";

    static readonly grpc::Marshaller<global::Grpc.Health.V1.HealthCheckRequest> __Marshaller_grpc_health_v1_HealthCheckRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Health.V1.HealthCheckRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Grpc.Health.V1.HealthCheckResponse> __Marshaller_grpc_health_v1_HealthCheckResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Health.V1.HealthCheckResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse> __Method_Check = new grpc::Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Check",
        __Marshaller_grpc_health_v1_HealthCheckRequest,
        __Marshaller_grpc_health_v1_HealthCheckResponse);

    static readonly grpc::Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse> __Method_Watch = new grpc::Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Watch",
        __Marshaller_grpc_health_v1_HealthCheckRequest,
        __Marshaller_grpc_health_v1_HealthCheckResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpc.Health.V1.HealthReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Health</summary>
    [grpc::BindServiceMethod(typeof(Health), "BindService")]
    public abstract partial class HealthBase
    {
      /// <summary>
      /// If the requested service is unknown, the call will fail with status
      /// NOT_FOUND.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Grpc.Health.V1.HealthCheckResponse> Check(global::Grpc.Health.V1.HealthCheckRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Performs a watch for the serving status of the requested service.
      /// The server will immediately send back a message indicating the current
      /// serving status.  It will then subsequently send a new message whenever
      /// the service's serving status changes.
      ///
      /// If the requested service is unknown when the call is received, the
      /// server will send a message setting the serving status to
      /// SERVICE_UNKNOWN but will *not* terminate the call.  If at some
      /// future point, the serving status of the service becomes known, the
      /// server will send a new message with the service's serving status.
      ///
      /// If the call terminates with status UNIMPLEMENTED, then clients
      /// should assume this method is not supported and should not retry the
      /// call.  If the call terminates with any other status (including OK),
      /// clients should retry the call with appropriate exponential backoff.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task Watch(global::Grpc.Health.V1.HealthCheckRequest request, grpc::IServerStreamWriter<global::Grpc.Health.V1.HealthCheckResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(HealthBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Check, serviceImpl.Check)
          .AddMethod(__Method_Watch, serviceImpl.Watch).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, HealthBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Check, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse>(serviceImpl.Check));
      serviceBinder.AddMethod(__Method_Watch, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse>(serviceImpl.Watch));
    }

  }
}
#endregion