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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RepositoryRuleCreation? creation = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.Creation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCreation)}");
                creation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleUpdate? update = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.Update)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleUpdate)}");
                update = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleDeletion? deletion = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.Deletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleDeletion)}");
                deletion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleRequiredLinearHistory? requiredLinearHistory = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.RequiredLinearHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleRequiredLinearHistory)}");
                requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleMergeQueue? mergeQueue = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.MergeQueue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMergeQueue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleMergeQueue)}");
                mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleRequiredDeployments? requiredDeployments = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.RequiredDeployments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleRequiredDeployments)}");
                requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleRequiredSignatures? requiredSignatures = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.RequiredSignatures)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleRequiredSignatures)}");
                requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRulePullRequest? pullRequest = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.PullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRulePullRequest)}");
                pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleRequiredStatusChecks? requiredStatusChecks = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.RequiredStatusChecks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleRequiredStatusChecks)}");
                requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleNonFastForward? nonFastForward = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.NonFastForward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleNonFastForward)}");
                nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleCommitMessagePattern? commitMessagePattern = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.CommitMessagePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCommitMessagePattern)}");
                commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.CommitAuthorEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCommitAuthorEmailPattern)}");
                commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleCommitterEmailPattern? committerEmailPattern = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.CommitterEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCommitterEmailPattern)}");
                committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleBranchNamePattern? branchNamePattern = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.BranchNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleBranchNamePattern)}");
                branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleTagNamePattern? tagNamePattern = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.TagNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleTagNamePattern)}");
                tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleVariant16? filePathRestriction = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.FilePathRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleVariant16)}");
                filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleVariant17? maxFilePathLength = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.MaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleVariant17)}");
                maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleVariant18? fileExtensionRestriction = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.FileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleVariant18)}");
                fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleVariant19? maxFileSize = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.MaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleVariant19)}");
                maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleWorkflows? workflows = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.Workflows)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleWorkflows)}");
                workflows = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleCodeScanning? codeScanning = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.CodeScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCodeScanning)}");
                codeScanning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RepositoryRule(
                discriminator?.Type,
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

            return result;
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePathRestriction, typeInfo);
            }
            else if (value.IsMaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFilePathLength, typeInfo);
            }
            else if (value.IsFileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileExtensionRestriction, typeInfo);
            }
            else if (value.IsMaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant19).Name}");
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