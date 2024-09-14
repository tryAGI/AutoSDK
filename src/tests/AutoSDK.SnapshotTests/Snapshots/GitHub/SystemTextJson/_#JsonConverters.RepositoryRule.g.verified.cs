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

            var
            readerCopy = reader;
            global::G.RepositoryRuleCreation? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCreation).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleUpdate? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleDeletion? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredLinearHistory? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredDeployments? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredSignatures? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRulePullRequest? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredStatusChecks? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleNonFastForward? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitMessagePattern? value10 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                value10 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitAuthorEmailPattern? value11 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                value11 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitterEmailPattern? value12 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                value12 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleBranchNamePattern? value13 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                value13 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleTagNamePattern? value14 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                value14 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleVariant15? value15 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant15).Name}");
                value15 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleVariant16? value16 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant16).Name}");
                value16 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleVariant17? value17 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant17).Name}");
                value17 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleVariant18? value18 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant18).Name}");
                value18 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleWorkflows? value19 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                value19 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCodeScanning? value20 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                value20 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.RepositoryRule(
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

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCreation).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value10 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value11 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value12 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value13 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value14 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value15 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant15).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value16 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant16).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value17 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant17).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value18 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleVariant18).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value19 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value20 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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