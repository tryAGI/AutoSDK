//HintName: JsonConverters.RepositoryRuleDetailed.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RepositoryRuleDetailedJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoryRuleDetailed>
    {
        /// <inheritdoc />
        public override global::G.RepositoryRuleDetailed Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>? value10 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>).Name}");
                value10 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>? value11 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                value11 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>? value12 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                value12 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>? value13 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                value13 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>? value14 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                value14 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>? value15 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                value15 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>? value16 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>).Name}");
                value16 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>? value17 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>).Name}");
                value17 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.RepositoryRuleDetailed(
                value1,
                value2,
                value3,
                value4,
                value5,
                value6,
                value7,
                value8,
                value9,
                value10,
                value11,
                value12,
                value13,
                value14,
                value15,
                value16,
                value17
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value10 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value11 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value12 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value13 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value14 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value15 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value16 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value17 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryRuleDetailed value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }
            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }
            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeInfo);
            }
            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeInfo);
            }
            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeInfo);
            }
            else if (value.IsValue14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeInfo);
            }
            else if (value.IsValue15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, typeInfo);
            }
            else if (value.IsValue16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, typeInfo);
            }
            else if (value.IsValue17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value17, typeInfo);
            }
        }
    }
}