using AutoSDK.Extensions;

namespace AutoSDK.UnitTests;

[TestClass]
public class SpecFormatDetectorTests
{
    [TestMethod]
    public void DetectFormat_Proto3Service_ReturnsGrpcProto()
    {
        const string proto = """
                             syntax = "proto3";

                             package demo;

                             service Greeter {
                               rpc SayHello (HelloRequest) returns (HelloReply);
                             }

                             message HelloRequest {
                               string name = 1;
                             }

                             message HelloReply {
                               string message = 1;
                             }
                             """;

        SpecFormatDetector.DetectFormat(proto).Should().Be(SpecFormat.GrpcProto);
    }

    [TestMethod]
    public void DetectFormat_OpenApiDocument_RemainsOpenApi()
    {
        const string openApi = """
                               openapi: 3.0.3
                               info:
                                 title: Demo
                                 version: 1.0.0
                               paths: {}
                               """;

        SpecFormatDetector.DetectFormat(openApi).Should().Be(SpecFormat.OpenApi);
    }
}
