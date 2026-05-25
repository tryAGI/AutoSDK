using AutoSDK.Generation;
using AutoSDK.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace AutoSDK.UnitTests;

[TestClass]
public class MultipartUploadHelpersTests
{
    [TestMethod]
    public void Helpers_WhenDisabled_OmitFile()
    {
        var settings = Settings.Default with { Namespace = "Demo" };

        var file = Sources.MultipartUploadHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void Helpers_WhenEnabled_EmitsTypedUploadFileWithFactories()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GenerateMultipartUploadHelpers = true,
        };

        var file = Sources.MultipartUploadHelpers(settings);

        file.Name.Should().Be("Demo.AutoSDKUploadFile.g.cs");
        file.Text.Should().Contain("public sealed class AutoSDKUploadFile");
        file.Text.Should().Contain("public static AutoSDKUploadFile FromBytes(");
        file.Text.Should().Contain("public static AutoSDKUploadFile FromStream(");
        file.Text.Should().Contain("public static AutoSDKUploadFile FromPath(");
        file.Text.Should().Contain("public string Filename { get; }");
        file.Text.Should().Contain("public string ContentType { get; }");
        file.Text.Should().Contain("public global::System.Net.Http.HttpContent ToHttpContent(string formFieldName)");
        // Mime guesser is also emitted.
        file.Text.Should().Contain("public static class AutoSDKMimeTypeGuesser");
        file.Text.Should().Contain("\".pdf\" => \"application/pdf\"");
        file.Text.Should().Contain("\".jpg\" or \".jpeg\" => \"image/jpeg\"");
        file.Text.Should().Contain("\".mp3\" => \"audio/mpeg\"");
        file.Text.Should().Contain("\".mp4\" => \"video/mp4\"");
        // Stream-vs-bytes guard rails.
        file.Text.Should().Contain("public global::System.ReadOnlyMemory<byte> Bytes");
        file.Text.Should().Contain("public global::System.IO.Stream OpenReadStream()");
    }

    [TestMethod]
    public void Helpers_HonorCustomClassName()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GenerateMultipartUploadHelpers = true,
            MultipartUploadHelperClassName = "PortablesFile",
        };

        var file = Sources.MultipartUploadHelpers(settings);

        file.Name.Should().Be("Demo.PortablesFile.g.cs");
        file.Text.Should().Contain("public sealed class PortablesFile");
        file.Text.Should().Contain("public static PortablesFile FromBytes(");
    }

    // Regression for tryAGI/AutoSDK#349: the generated XML doc crefs must compile cleanly
    // under GenerateDocumentationFile=true. A cref like ReadOnlyMemory{byte} (C# keyword in the
    // generic type-argument list) raised CS1584/CS1658, and the bare FromBytes cref raised CS0419
    // (ambiguous overload). Compile the emitted helper with documentation diagnostics enabled and
    // assert none of those doc-comment diagnostics appear.
    [TestMethod]
    public void Helpers_EmitDocCommentsThatCompileWithoutCrefErrors()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GenerateMultipartUploadHelpers = true,
        };

        var file = Sources.MultipartUploadHelpers(settings);

        var syntaxTree = CSharpSyntaxTree.ParseText(
            file.Text,
            new CSharpParseOptions(documentationMode: DocumentationMode.Diagnose));

        var references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(global::System.IO.Path.PathSeparator)
            .Where(static path => !string.IsNullOrEmpty(path))
            .Select(static path => MetadataReference.CreateFromFile(path))
            .ToArray();

        var compilation = CSharpCompilation.Create(
            assemblyName: "AutoSDKUploadFileDocCheck",
            syntaxTrees: [syntaxTree],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        var docDiagnostics = compilation.GetDiagnostics()
            .Where(static diagnostic =>
                diagnostic.Severity == DiagnosticSeverity.Error ||
                diagnostic.Severity == DiagnosticSeverity.Warning)
            .Where(static diagnostic => diagnostic.Id is
                "CS1584" or // XML comment has syntactically incorrect cref attribute
                "CS1658" or // Type parameter declaration must be an identifier not a type
                "CS0081" or // Type parameter declaration must be an identifier not a type
                "CS0419")   // Ambiguous reference in cref attribute
            .Select(static diagnostic => diagnostic.ToString())
            .ToArray();

        docDiagnostics.Should().BeEmpty();
    }
}
