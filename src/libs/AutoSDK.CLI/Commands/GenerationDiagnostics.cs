using System.Globalization;
using AutoSDK.Models;

namespace AutoSDK.CLI.Commands;

internal readonly record struct RenderHotspot(string Name, int Characters);

internal readonly record struct GenerationDiagnostics(
    bool CacheHit,
    string CacheReason,
    TimeSpan Total,
    TimeSpan Setup,
    TimeSpan InputRead,
    TimeSpan CacheLockWait,
    TimeSpan CacheValidation,
    TimeSpan Pipeline,
    TimeSpan Render,
    TimeSpan SnippetManifest,
    TimeSpan NormalizeCompareWriteAndCleanup,
    TimeSpan CacheWrite,
    Times CoreTimes,
    IReadOnlyList<RenderHotspot> RenderHotspots,
    GeneratedFileWriteResult Files,
    long TotalAllocatedBytes,
    long CacheAllocatedBytes,
    long PipelineAllocatedBytes,
    long RenderAllocatedBytes,
    long SnippetAllocatedBytes,
    long WriteAllocatedBytes)
{
    public async Task WriteAsync(TextWriter writer)
    {
        writer = writer ?? throw new ArgumentNullException(nameof(writer));

        await writer.WriteLineAsync("AutoSDK generation diagnostics:").ConfigureAwait(false);
        await writer.WriteLineAsync($"  cache_hit: {(CacheHit ? "true" : "false")}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  cache_reason: {CacheReason}").ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "total_ms", Total).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "setup_ms", Setup).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "input_read_ms", InputRead).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "cache_lock_wait_ms", CacheLockWait).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "cache_validation_ms", CacheValidation).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "pipeline_ms", Pipeline).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_ms", CoreTimes.Parsing).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_traversal_ms", CoreTimes.TraversalTree).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_naming_ms", CoreTimes.Naming).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_resolve_references_ms", CoreTimes.ResolveReferences).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_filtering_ms", CoreTimes.Filtering).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_compute_data_ms", CoreTimes.ComputeData).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_compute_classes_ms", CoreTimes.ComputeDataClasses).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "render_ms", Render).ConfigureAwait(false);
        foreach (var hotspot in RenderHotspots)
        {
            await writer.WriteLineAsync($"  render_hotspot: {hotspot.Characters.ToString(CultureInfo.InvariantCulture)} {hotspot.Name}").ConfigureAwait(false);
        }
        await WriteMillisecondsAsync(writer, "snippet_manifest_ms", SnippetManifest).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "normalize_compare_write_cleanup_ms", NormalizeCompareWriteAndCleanup).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "cache_write_ms", CacheWrite).ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_generated: {Files.GeneratedCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_written: {Files.WrittenCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_unchanged: {Files.UnchangedCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_deleted: {Files.DeletedCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  normalized_lines: {Files.NormalizedLineCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  generated_bytes: {Files.GeneratedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  written_bytes: {Files.WrittenBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  allocated_bytes: {TotalAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  cache_allocated_bytes: {CacheAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  pipeline_allocated_bytes: {PipelineAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  render_allocated_bytes: {RenderAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  snippet_allocated_bytes: {SnippetAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  write_allocated_bytes: {WriteAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
    }

    private static Task WriteMillisecondsAsync(TextWriter writer, string name, TimeSpan value)
    {
        return writer.WriteLineAsync($"  {name}: {value.TotalMilliseconds.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}
