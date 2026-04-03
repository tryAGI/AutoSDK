using AutoSDK.Grpc;

namespace AutoSDK.UnitTests;

[TestClass]
public class GrpcProtoParserTests
{
    [TestMethod]
    public void Parse_ExtractsPackageNamespaceImportsAndServices()
    {
        const string proto = """
                             syntax = "proto3";
                             // import "ignored.proto";
                             package demo.v1;

                             option csharp_namespace = "Demo.V1";

                             import "messages/common.proto";
                             import public "google/protobuf/timestamp.proto";

                             /* service Hidden {
                                  rpc Noop (A) returns (B);
                                }
                             */

                             service Greeter {
                               rpc SayHello (HelloRequest) returns (HelloReply);
                             }

                             service Admin {
                             }
                             """;

        var document = GrpcProtoParser.Parse(proto);

        document.PackageName.Should().Be("demo.v1");
        document.CSharpNamespace.Should().Be("Demo.V1");
        document.Imports.Should().Equal("messages/common.proto", "google/protobuf/timestamp.proto");
        document.Services.Should().Equal("Greeter", "Admin");
    }
}
