//HintName: JsonConverters.RepositoryRuleDetailed.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>? value3 = default;
            try
            {
                value3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>? value4 = default;
            try
            {
                value4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>? value5 = default;
            try
            {
                value5 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>? value6 = default;
            try
            {
                value6 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>? value7 = default;
            try
            {
                value7 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>? value8 = default;
            try
            {
                value8 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>? value9 = default;
            try
            {
                value9 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>? value10 = default;
            try
            {
                value10 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? value11 = default;
            try
            {
                value11 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? value12 = default;
            try
            {
                value12 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>? value13 = default;
            try
            {
                value13 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>? value14 = default;
            try
            {
                value14 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>? value15 = default;
            try
            {
                value15 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>? value16 = default;
            try
            {
                value16 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>>(ref readerCopy, options);
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

                value16
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>).Name}>");
            }

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value3 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value4 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value5 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value6 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value7 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value8 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value9 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value10 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value11 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value12 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value13 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value14 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value15 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
            }

            else if (value16 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>>(ref reader, options);
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

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>).Name}, {typeof(global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>).Name}> object.");
            }

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeof(global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeof(global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeof(global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeof(global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeof(global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeof(global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeof(global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeof(global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue11)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeof(global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue12)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeof(global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue13)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeof(global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue14)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeof(global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue15)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, typeof(global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>), options);
            }

            else if (value.IsValue16)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, typeof(global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>), options);
            }
        }
    }
}