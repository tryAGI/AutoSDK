using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class HttpExceptionHierarchyTests
{
    [TestMethod]
    public void Exceptions_WhenHierarchyDisabled_OmitsTypedSubclasses()
    {
        var settings = Settings.Default with { Namespace = "Demo" };

        var source = Sources.GenerateExceptions(settings);

        source.Should().Contain("public partial class ApiException");
        source.Should().NotContain("public partial class AuthenticationException");
        source.Should().NotContain("public partial class RateLimitException");
        source.Should().NotContain("public partial class ServerException");
    }

    [TestMethod]
    public void Exceptions_WhenHierarchyEnabled_EmitsTypedSubclassesAndFactory()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GenerateHttpExceptionHierarchy = true,
        };

        var source = Sources.GenerateExceptions(settings);

        source.Should().Contain("public partial class AuthenticationException : global::Demo.ApiException");
        source.Should().Contain("public partial class PaymentRequiredException : global::Demo.ApiException");
        source.Should().Contain("public partial class AuthorizationException : global::Demo.ApiException");
        source.Should().Contain("public partial class NotFoundException : global::Demo.ApiException");
        source.Should().Contain("public partial class RequestTimeoutException : global::Demo.ApiException");
        source.Should().Contain("public partial class ConflictException : global::Demo.ApiException");
        source.Should().Contain("public partial class ValidationException : global::Demo.ApiException");
        source.Should().Contain("public partial class RateLimitException : global::Demo.ApiException");
        source.Should().Contain("public partial class ServerException : global::Demo.ApiException");

        // Typed counterparts
        source.Should().Contain("public partial class AuthenticationException<T> : global::Demo.ApiException<T>");
        source.Should().Contain("public partial class RateLimitException<T> : global::Demo.ApiException<T>");
        source.Should().Contain("public partial class ServerException<T> : global::Demo.ApiException<T>");

        // RateLimit exposes RetryAfter
        source.Should().Contain("public global::System.TimeSpan? RetryAfter { get; set; }");

        // Factory routes by status code
        source.Should().Contain("case 401: return new global::Demo.AuthenticationException(message, innerException);");
        source.Should().Contain("case 429:");
        source.Should().Contain("var retryAfter = global::Demo.ApiException.TryParseRetryAfter(responseHeaders);");
        source.Should().Contain("if ((int)statusCode >= 500 && (int)statusCode <= 599)");
        source.Should().Contain("return new global::Demo.ServerException(message, innerException, statusCode);");
    }

    [TestMethod]
    public void Exceptions_FactoryFallbackOnUnknownStatus_ReturnsPlainApiException()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GenerateHttpExceptionHierarchy = true,
        };

        var source = Sources.GenerateExceptions(settings);

        // Fallback branch after the switch + 5xx check
        source.Should().Contain("return new global::Demo.ApiException(message, innerException, statusCode);");
    }

    [TestMethod]
    public void Exceptions_FactoryAlwaysAvailable_EvenWithoutHierarchy()
    {
        // Create factory is part of the always-on ApiException surface; it just returns
        // a plain ApiException when the hierarchy flag is off, so consumer code can call
        // it without branching on the generator flag.
        var settings = Settings.Default with { Namespace = "Demo" };

        var source = Sources.GenerateExceptions(settings);

        source.Should().Contain("public static global::Demo.ApiException Create(");
        source.Should().Contain("return new global::Demo.ApiException(message, innerException, statusCode);");
    }

    [TestMethod]
    public void Exceptions_TryParseRetryAfter_AlwaysEmitted()
    {
        var settings = Settings.Default with { Namespace = "Demo" };

        var source = Sources.GenerateExceptions(settings);

        source.Should().Contain("public static global::System.TimeSpan? TryParseRetryAfter(");
    }
}
