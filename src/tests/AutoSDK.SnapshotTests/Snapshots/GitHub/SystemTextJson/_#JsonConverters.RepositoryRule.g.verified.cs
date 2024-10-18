//HintName: JsonConverters.RepositoryRule.g.cs
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

            global::G.RepositoryRuleCreation? value1 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.Creation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCreation)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleUpdate? value2 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.Update)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleUpdate)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleDeletion? value3 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.Deletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleDeletion)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleRequiredLinearHistory? value4 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.RequiredLinearHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleRequiredLinearHistory)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleRequiredDeployments? value5 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.RequiredDeployments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleRequiredDeployments)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleRequiredSignatures? value6 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.RequiredSignatures)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleRequiredSignatures)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRulePullRequest? value7 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.PullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRulePullRequest)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleRequiredStatusChecks? value8 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.RequiredStatusChecks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleRequiredStatusChecks)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleNonFastForward? value9 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.NonFastForward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleNonFastForward)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleCommitMessagePattern? value10 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.CommitMessagePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCommitMessagePattern)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleCommitAuthorEmailPattern? value11 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.CommitAuthorEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCommitAuthorEmailPattern)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleCommitterEmailPattern? value12 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.CommitterEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCommitterEmailPattern)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleBranchNamePattern? value13 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.BranchNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleBranchNamePattern)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleTagNamePattern? value14 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.TagNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleTagNamePattern)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleVariant15? value15 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.FilePathRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleVariant15)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleVariant16? value16 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.MaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleVariant16)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleVariant17? value17 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.FileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleVariant17)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleVariant18? value18 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.MaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleVariant18)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleWorkflows? value19 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.Workflows)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleWorkflows)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RepositoryRuleCodeScanning? value20 = default;
            if (discriminator?.Type == global::G.RepositoryRuleDiscriminatorType.CodeScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RepositoryRuleCodeScanning)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RepositoryRule(
                discriminator?.Type,
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
                value17,
                value18,
                value19,
                value20
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

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCreation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }
            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }
            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeInfo);
            }
            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeInfo);
            }
            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeInfo);
            }
            else if (value.IsValue14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeInfo);
            }
            else if (value.IsValue15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, typeInfo);
            }
            else if (value.IsValue16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, typeInfo);
            }
            else if (value.IsValue17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value17, typeInfo);
            }
            else if (value.IsValue18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value18, typeInfo);
            }
            else if (value.IsValue19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value19, typeInfo);
            }
            else if (value.IsValue20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value20, typeInfo);
            }
        }
    }
}