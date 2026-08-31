using System.Globalization;
using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.CLI.Commands;

internal readonly record struct RenderHotspot(string Name, int Characters);

internal readonly record struct GenerationDiagnostics(
    bool CacheHit,
    string CacheReason,
    bool CacheLockAcquired,
    string CacheLockReason,
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
    IReadOnlyList<CSharpRenderPhase> RenderPhases,
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
        await writer.WriteLineAsync($"  cache_lock_acquired: {(CacheLockAcquired ? "true" : "false")}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  cache_lock_reason: {CacheLockReason}").ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "total_ms", Total).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "setup_ms", Setup).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "input_read_ms", InputRead).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "cache_lock_wait_ms", CacheLockWait).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "cache_validation_ms", CacheValidation).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "pipeline_ms", Pipeline).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_ms", CoreTimes.Parsing).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_json_syntax_ms", CoreTimes.OpenApiParsing.JsonSyntax).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_compat_normalization_ms", CoreTimes.OpenApiParsing.CompatibilityNormalization).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_microsoft_reader_ms", CoreTimes.OpenApiParsing.MicrosoftReader).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_compat_walker_ms", CoreTimes.OpenApiParsing.CompatibilityWalker).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_ms", CoreTimes.OpenApiParsing.PostProcessing).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_setup_injection_ms", CoreTimes.OpenApiParsing.PostSetupAndInjection).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_discriminators_ms", CoreTimes.OpenApiParsing.PostDiscriminators).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_missing_path_parameters_ms", CoreTimes.OpenApiParsing.PostMissingPathParameters).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_overrides_naming_ms", CoreTimes.OpenApiParsing.PostOverridesAndNaming).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_schema_sanitizers_ms", CoreTimes.OpenApiParsing.PostSchemaSanitizers).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_schema_sanitizers_fern_types_ms", CoreTimes.OpenApiParsing.PostFernTypeNormalization).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_schema_sanitizers_numeric_constraints_ms", CoreTimes.OpenApiParsing.PostNumericConstraintSanitization).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_schema_sanitizers_large_integer_formats_ms", CoreTimes.OpenApiParsing.PostLargeIntegerFormatInference).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_parsing_postprocess_schema_sanitizers_discriminators_ms", CoreTimes.OpenApiParsing.PostDiscriminatorSanitization).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_traversal_ms", CoreTimes.TraversalTree).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_naming_ms", CoreTimes.Naming).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_resolve_references_ms", CoreTimes.ResolveReferences).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_filtering_ms", CoreTimes.Filtering).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_compute_data_ms", CoreTimes.ComputeData).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_compute_classes_ms", CoreTimes.ComputeDataClasses).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_collect_schemas_ms", CoreTimes.DataEnrichment.CollectSchemas).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_polymorphic_arrays_ms", CoreTimes.DataEnrichment.PolymorphicArrays).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_schema_models_ms", CoreTimes.DataEnrichment.SchemaModels).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_operations_ms", CoreTimes.DataEnrichment.Operations).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_endpoints_ms", CoreTimes.DataEnrichment.EndPoints).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_authorizations_ms", CoreTimes.DataEnrichment.Authorizations).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_converters_ms", CoreTimes.DataEnrichment.Converters).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_tags_clients_ms", CoreTimes.DataEnrichment.TagsAndClients).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "core_json_types_outputs_ms", CoreTimes.DataEnrichment.JsonTypesAndOutputs).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "render_ms", Render).ConfigureAwait(false);
        foreach (var phase in RenderPhases)
        {
            await WriteMillisecondsAsync(writer, $"render_{phase.Name}_ms", phase.Elapsed).ConfigureAwait(false);
            await writer.WriteLineAsync($"  render_{phase.Name}_allocated_bytes: {phase.AllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
            await writer.WriteLineAsync($"  render_{phase.Name}_files: {phase.FileCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
            await writer.WriteLineAsync($"  render_{phase.Name}_characters: {phase.CharacterCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        }
        foreach (var hotspot in RenderHotspots)
        {
            await writer.WriteLineAsync($"  render_hotspot: {hotspot.Characters.ToString(CultureInfo.InvariantCulture)} {hotspot.Name}").ConfigureAwait(false);
        }
        await WriteMillisecondsAsync(writer, "snippet_manifest_ms", SnippetManifest).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "normalize_compare_write_cleanup_ms", NormalizeCompareWriteAndCleanup).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "output_prepare_ms", Files.Diagnostics.Preparation).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "output_parallel_processing_ms", Files.Diagnostics.ParallelProcessing).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "output_normalize_encode_hash_worker_ms", Files.Diagnostics.NormalizeEncodeHashWorker).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "output_compare_worker_ms", Files.Diagnostics.CompareWorker).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "output_physical_write_worker_ms", Files.Diagnostics.PhysicalWriteWorker).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "output_cache_metadata_worker_ms", Files.Diagnostics.CacheMetadataWorker).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "output_stale_cleanup_ms", Files.Diagnostics.StaleCleanup).ConfigureAwait(false);
        await WriteMillisecondsAsync(writer, "cache_write_ms", CacheWrite).ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_generated: {Files.GeneratedCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_written: {Files.WrittenCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_created: {Files.CreatedCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_replaced: {Files.ReplacedCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_unchanged: {Files.UnchangedCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  files_deleted: {Files.DeletedCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  normalized_lines: {Files.NormalizedLineCount.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  generated_bytes: {Files.GeneratedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  written_bytes: {Files.WrittenBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  allocated_bytes: {TotalAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  cache_allocated_bytes: {CacheAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  pipeline_allocated_bytes: {PipelineAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_allocated_bytes: {CoreTimes.AllocParsing.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_json_syntax_allocated_bytes: {CoreTimes.OpenApiParsing.AllocJsonSyntax.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_compat_normalization_allocated_bytes: {CoreTimes.OpenApiParsing.AllocCompatibilityNormalization.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_microsoft_reader_allocated_bytes: {CoreTimes.OpenApiParsing.AllocMicrosoftReader.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_compat_walker_allocated_bytes: {CoreTimes.OpenApiParsing.AllocCompatibilityWalker.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostProcessing.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_setup_injection_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostSetupAndInjection.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_discriminators_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostDiscriminators.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_missing_path_parameters_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostMissingPathParameters.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_overrides_naming_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostOverridesAndNaming.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_schema_sanitizers_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostSchemaSanitizers.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_schema_sanitizers_fern_types_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostFernTypeNormalization.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_schema_sanitizers_numeric_constraints_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostNumericConstraintSanitization.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_schema_sanitizers_large_integer_formats_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostLargeIntegerFormatInference.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_parsing_postprocess_schema_sanitizers_discriminators_allocated_bytes: {CoreTimes.OpenApiParsing.AllocPostDiscriminatorSanitization.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_traversal_allocated_bytes: {CoreTimes.AllocTraversalTree.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_naming_allocated_bytes: {CoreTimes.AllocNaming.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_resolve_references_allocated_bytes: {CoreTimes.AllocResolveReferences.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_filtering_allocated_bytes: {CoreTimes.AllocFiltering.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_compute_data_allocated_bytes: {CoreTimes.AllocComputeData.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_compute_classes_allocated_bytes: {CoreTimes.AllocComputeDataClasses.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_collect_schemas_allocated_bytes: {CoreTimes.DataEnrichment.AllocCollectSchemas.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_polymorphic_arrays_allocated_bytes: {CoreTimes.DataEnrichment.AllocPolymorphicArrays.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_schema_models_allocated_bytes: {CoreTimes.DataEnrichment.AllocSchemaModels.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_operations_allocated_bytes: {CoreTimes.DataEnrichment.AllocOperations.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_endpoints_allocated_bytes: {CoreTimes.DataEnrichment.AllocEndPoints.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_authorizations_allocated_bytes: {CoreTimes.DataEnrichment.AllocAuthorizations.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_converters_allocated_bytes: {CoreTimes.DataEnrichment.AllocConverters.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_tags_clients_allocated_bytes: {CoreTimes.DataEnrichment.AllocTagsAndClients.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  core_json_types_outputs_allocated_bytes: {CoreTimes.DataEnrichment.AllocJsonTypesAndOutputs.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  render_allocated_bytes: {RenderAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  snippet_allocated_bytes: {SnippetAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
        await writer.WriteLineAsync($"  write_allocated_bytes: {WriteAllocatedBytes.ToString(CultureInfo.InvariantCulture)}").ConfigureAwait(false);
    }

    private static Task WriteMillisecondsAsync(TextWriter writer, string name, TimeSpan value)
    {
        return writer.WriteLineAsync($"  {name}: {value.TotalMilliseconds.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}
