using AutoSDK.Models;
using Microsoft.CodeAnalysis;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace AutoSDK.SourceGenerators;

/// <summary>
/// 
/// </summary>
public static class IncrementalValuesProviderExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <param name="source"></param>
    public static void AddSource(
        this IncrementalValuesProvider<FileWithName> source,
        IncrementalGeneratorInitializationContext context)
    {
        context.RegisterSourceOutput(source, static (context, file) =>
        {
            if (file.IsEmpty)
            {
                return;
            }

            context.AddSource(
                hintName: file.Name,
                source: file.Text);
        });
    }

    /// <summary>
    /// Adds a source file to the context during the incremental generation process
    /// based on the given file's content and name.
    /// </summary>
    /// <param name="source">The incremental value provider that supplies the file to be added.</param>
    /// <param name="context">The context used to register and add the source file.</param>
    public static void AddSource(
        this IncrementalValueProvider<FileWithName> source,
        IncrementalGeneratorInitializationContext context)
    {
        context.RegisterSourceOutput(source, static (context, file) =>
        {
            if (file.IsEmpty)
            {
                return;
            }

            context.AddSource(
                hintName: file.Name,
                source: file.Text);
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    /// <param name="selector"></param>
    /// <param name="initializationContext"></param>
    /// <param name="id"></param>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <returns></returns>
    public static IncrementalValueProvider<TResult> SelectAndReportExceptions<TSource, TResult>(
        this IncrementalValueProvider<TSource> source,
        Func<TSource, CancellationToken, TResult> selector,
        IncrementalGeneratorInitializationContext initializationContext,
        string id = "SRE001")
    {
        var outputWithErrors = source
            .Select<TSource, (TResult? Value, Exception? Exception)>((value, cancellationToken) =>
            {
                cancellationToken.ThrowIfCancellationRequested();

                try
                {
                    return (Value: selector(value, cancellationToken), Exception: null);
                }
                catch (Exception exception)
                {
                    return (Value: default, Exception: exception);
                }
            });

        initializationContext.RegisterSourceOutput(outputWithErrors,
            (context, tuple) =>
            {
                if (tuple.Exception is null)
                {
                    return;
                }

                context.ReportException(id: id, exception: tuple.Exception);
            });

        return outputWithErrors
            .Select(static (x, _) => x.Value!);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    /// <param name="selector"></param>
    /// <param name="initializationContext"></param>
    /// <param name="id"></param>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <returns></returns>
    public static IncrementalValuesProvider<TResult> SelectAndReportExceptions<TSource, TResult>(
        this IncrementalValuesProvider<TSource> source,
        Func<TSource, CancellationToken, TResult> selector,
        IncrementalGeneratorInitializationContext initializationContext,
        string id = "SRE001")
    {
        var outputWithErrors = source
            .Select<TSource, (TResult? Value, Exception? Exception)>((value, cancellationToken) =>
            {
                cancellationToken.ThrowIfCancellationRequested();

                try
                {
                    return (Value: selector(value, cancellationToken), Exception: null);
                }
                catch (Exception exception)
                {
                    return (Value: default, Exception: exception);
                }
            });

        initializationContext.RegisterSourceOutput(outputWithErrors
            .Where(static x => x.Exception is not null),
            (context, tuple) =>
            {
                context.ReportException(id: id, exception: tuple.Exception!);
            });

        return outputWithErrors
            .Where(static x => x.Exception is null)
            .Select(static (x, _) => x.Value!);
    }
}
