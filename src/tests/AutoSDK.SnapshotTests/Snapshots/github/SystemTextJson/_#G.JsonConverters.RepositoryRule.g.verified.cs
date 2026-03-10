//HintName: G.JsonConverters.RepositoryRule.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RepositoryRuleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoryRule>
    {
        /// <inheritdoc />
        public override global::G.RepositoryRule Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RepositoryRuleCreation? creation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCreation).Name}");
                creation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleUpdate? update = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                update = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleDeletion? deletion = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                deletion = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredLinearHistory? requiredLinearHistory = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleMergeQueue? mergeQueue = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMergeQueue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMergeQueue).Name}");
                mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredDeployments? requiredDeployments = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredSignatures? requiredSignatures = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRulePullRequest? pullRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredStatusChecks? requiredStatusChecks = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleNonFastForward? nonFastForward = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitMessagePattern? commitMessagePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitterEmailPattern? committerEmailPattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleBranchNamePattern? branchNamePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleTagNamePattern? tagNamePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleFilePathRestriction? filePathRestriction = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFilePathRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFilePathRestriction).Name}");
                filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleMaxFilePathLength? maxFilePathLength = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFilePathLength> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFilePathLength).Name}");
                maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFileExtensionRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFileExtensionRestriction).Name}");
                fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleMaxFileSize? maxFileSize = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFileSize> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFileSize).Name}");
                maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleWorkflows? workflows = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                workflows = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCodeScanning? codeScanning = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                codeScanning = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.RepositoryRule(
                creation,

                update,

                deletion,

                requiredLinearHistory,

                mergeQueue,

                requiredDeployments,

                requiredSignatures,

                pullRequest,

                requiredStatusChecks,

                nonFastForward,

                commitMessagePattern,

                commitAuthorEmailPattern,

                committerEmailPattern,

                branchNamePattern,

                tagNamePattern,

                filePathRestriction,

                maxFilePathLength,

                fileExtensionRestriction,

                maxFileSize,

                workflows,

                codeScanning
                );

            if (creation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCreation).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (update != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (deletion != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (requiredLinearHistory != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mergeQueue != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMergeQueue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMergeQueue).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (requiredDeployments != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (requiredSignatures != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (pullRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (requiredStatusChecks != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (nonFastForward != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (commitMessagePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (commitAuthorEmailPattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (committerEmailPattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (branchNamePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tagNamePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (filePathRestriction != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFilePathRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFilePathRestriction).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (maxFilePathLength != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFilePathLength> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFilePathLength).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileExtensionRestriction != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFileExtensionRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFileExtensionRestriction).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (maxFileSize != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFileSize> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFileSize).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (workflows != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeScanning != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryRule value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCreation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Creation, typeInfo);
            }
            else if (value.IsUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Update, typeInfo);
            }
            else if (value.IsDeletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deletion, typeInfo);
            }
            else if (value.IsRequiredLinearHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredLinearHistory, typeInfo);
            }
            else if (value.IsMergeQueue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMergeQueue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMergeQueue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MergeQueue, typeInfo);
            }
            else if (value.IsRequiredDeployments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredDeployments, typeInfo);
            }
            else if (value.IsRequiredSignatures)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredSignatures, typeInfo);
            }
            else if (value.IsPullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequest, typeInfo);
            }
            else if (value.IsRequiredStatusChecks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredStatusChecks, typeInfo);
            }
            else if (value.IsNonFastForward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NonFastForward, typeInfo);
            }
            else if (value.IsCommitMessagePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitMessagePattern, typeInfo);
            }
            else if (value.IsCommitAuthorEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitAuthorEmailPattern, typeInfo);
            }
            else if (value.IsCommitterEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitterEmailPattern, typeInfo);
            }
            else if (value.IsBranchNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BranchNamePattern, typeInfo);
            }
            else if (value.IsTagNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TagNamePattern, typeInfo);
            }
            else if (value.IsFilePathRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFilePathRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFilePathRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePathRestriction, typeInfo);
            }
            else if (value.IsMaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFilePathLength?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFilePathLength).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFilePathLength, typeInfo);
            }
            else if (value.IsFileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFileExtensionRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFileExtensionRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileExtensionRestriction, typeInfo);
            }
            else if (value.IsMaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFileSize?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFileSize).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFileSize, typeInfo);
            }
            else if (value.IsWorkflows)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Workflows, typeInfo);
            }
            else if (value.IsCodeScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeScanning, typeInfo);
            }
        }
    }
}