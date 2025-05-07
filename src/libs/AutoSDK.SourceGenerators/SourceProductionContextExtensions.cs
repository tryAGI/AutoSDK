using Microsoft.CodeAnalysis;

namespace AutoSDK.SourceGenerators;

/// <summary>
/// 
/// </summary>
public static class SourceProductionContextExtensions
{
    /// <summary>
    /// Generates a diagnostic for the selected exception.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="id"></param>
    /// <param name="exception"></param>
    /// <param name="prefix"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public static void ReportException(
        this SourceProductionContext context,
        string id,
        Exception exception,
        string? prefix = null)
    {
        id = id ?? throw new ArgumentNullException(nameof(id));
        exception = exception ?? throw new ArgumentNullException(nameof(exception));

        context.ReportDiagnostic(exception.ToDiagnostic(id, prefix));
    }

    /// <summary>
    /// Creates a diagnostic for the selected exception.
    /// </summary>
    /// <param name="exception"></param>
    /// <param name="id"></param>
    /// <param name="prefix"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public static Diagnostic ToDiagnostic(
        this Exception exception,
        string id,
        string? prefix = null)
    {
        exception = exception ?? throw new ArgumentNullException(nameof(exception));
        id = id ?? throw new ArgumentNullException(nameof(id));

        if (prefix != null)
        {
            id = $"{prefix}{id}";
        }

        return Diagnostic.Create(
            new DiagnosticDescriptor(
                id,
                "Exception: ",
                $"{exception}",
                "Usage",
                DiagnosticSeverity.Error,
                true),
            Location.None);
    }
}
