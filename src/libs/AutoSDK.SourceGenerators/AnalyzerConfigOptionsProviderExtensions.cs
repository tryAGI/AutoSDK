using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

// ReSharper disable MemberCanBePrivate.Global

namespace AutoSDK.SourceGenerators;

/// <summary>
/// 
/// </summary>
public static class AnalyzerConfigOptionsProviderExtensions
{
    private static string GetFullName(string name, string? prefix = null)
    {
        return prefix == null
            ? name
            : $"{prefix}_{name}";
    }

    /// <summary>
    /// Returns the value of the global option, or null if the option is missing or an empty string.
    /// </summary>
    /// <param name="options"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string? GetOption(
        this AnalyzerConfigOptions options,
        string key)
    {
        options = options ?? throw new ArgumentNullException(nameof(options));
        key = key ?? throw new ArgumentNullException(nameof(key));

        return
            options.TryGetValue(key, out var result) &&
            !string.IsNullOrWhiteSpace(result)
                ? result
                : null;
    }

    /// <summary>
    /// Returns the value of the global option, or null if the option is missing or an empty string.
    /// </summary>
    /// <param name="provider"></param>
    /// <param name="name"></param>
    /// <param name="prefix"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string? GetGlobalOption(
        this AnalyzerConfigOptionsProvider provider,
        string name,
        string? prefix = null)
    {
        provider = provider ?? throw new ArgumentNullException(nameof(provider));
        name = name ?? throw new ArgumentNullException(nameof(name));

        return provider.GlobalOptions.GetOption($"build_property.{GetFullName(name, prefix)}");
    }

    /// <summary>
    /// Returns the value of the <see cref="AdditionalText"/> option, or null if the option is missing or an empty string.
    /// </summary>
    /// <param name="provider"></param>
    /// <param name="text"></param>
    /// <param name="name"></param>
    /// <param name="group">Default: AdditionalFiles</param>
    /// <param name="prefix"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string? GetOption(
        this AnalyzerConfigOptionsProvider provider,
        AdditionalText text,
        string name,
        string? group = null,
        string? prefix = null)
    {
        provider = provider ?? throw new ArgumentNullException(nameof(provider));
        name = name ?? throw new ArgumentNullException(nameof(name));
        group ??= "AdditionalFiles";

        return provider.GetOptions(text).GetOption($"build_metadata.{group}.{GetFullName(name, prefix)}");
    }

    /// <summary>
    /// Returns the value of the global option, or throws an <see cref="InvalidOperationException"/>.
    /// </summary>
    /// <param name="provider"></param>
    /// <param name="name"></param>
    /// <param name="prefix"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static string GetRequiredGlobalOption(
        this AnalyzerConfigOptionsProvider provider,
        string name,
        string? prefix = null)
    {
        return
            provider.GetGlobalOption(name, prefix) ??
            throw new InvalidOperationException($"{GetFullName(name, prefix)} MSBuild property is required.");
    }

    /// <summary>
    /// Returns the value of the <see cref="AdditionalText"/> option, or throws an <see cref="InvalidOperationException"/>.
    /// </summary>
    /// <param name="provider"></param>
    /// <param name="text"></param>
    /// <param name="name"></param>
    /// <param name="prefix"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static string GetRequiredOption(
        this AnalyzerConfigOptionsProvider provider,
        AdditionalText text,
        string name,
        string? prefix = null)
    {
        return
            provider.GetOption(text, name, prefix) ??
            throw new InvalidOperationException($"{GetFullName(name, prefix)} metadata for AdditionalText is required.");
    }
}
