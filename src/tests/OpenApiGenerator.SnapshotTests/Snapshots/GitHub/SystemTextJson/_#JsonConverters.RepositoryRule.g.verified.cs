//HintName: JsonConverters.RepositoryRule.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::G.RepositoryRuleCreation? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCreation>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleUpdate? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleUpdate>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleDeletion? value3 = default;
            try
            {
                value3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleDeletion>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredLinearHistory? value4 = default;
            try
            {
                value4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredLinearHistory>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredDeployments? value5 = default;
            try
            {
                value5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredDeployments>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredSignatures? value6 = default;
            try
            {
                value6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredSignatures>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRulePullRequest? value7 = default;
            try
            {
                value7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRulePullRequest>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleRequiredStatusChecks? value8 = default;
            try
            {
                value8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredStatusChecks>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleNonFastForward? value9 = default;
            try
            {
                value9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleNonFastForward>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitMessagePattern? value10 = default;
            try
            {
                value10 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitMessagePattern>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitAuthorEmailPattern? value11 = default;
            try
            {
                value11 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitAuthorEmailPattern>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCommitterEmailPattern? value12 = default;
            try
            {
                value12 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitterEmailPattern>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleBranchNamePattern? value13 = default;
            try
            {
                value13 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleBranchNamePattern>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleTagNamePattern? value14 = default;
            try
            {
                value14 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleTagNamePattern>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleVariant15? value15 = default;
            try
            {
                value15 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleVariant15>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleVariant16? value16 = default;
            try
            {
                value16 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleVariant16>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleVariant17? value17 = default;
            try
            {
                value17 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleVariant17>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleVariant18? value18 = default;
            try
            {
                value18 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleVariant18>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleWorkflows? value19 = default;
            try
            {
                value19 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleWorkflows>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RepositoryRuleCodeScanning? value20 = default;
            try
            {
                value20 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCodeScanning>(ref readerCopy, options);
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
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::G.RepositoryRuleCreation).Name}, {typeof(global::G.RepositoryRuleUpdate).Name}, {typeof(global::G.RepositoryRuleDeletion).Name}, {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}, {typeof(global::G.RepositoryRuleRequiredDeployments).Name}, {typeof(global::G.RepositoryRuleRequiredSignatures).Name}, {typeof(global::G.RepositoryRulePullRequest).Name}, {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}, {typeof(global::G.RepositoryRuleNonFastForward).Name}, {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}, {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}, {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}, {typeof(global::G.RepositoryRuleBranchNamePattern).Name}, {typeof(global::G.RepositoryRuleTagNamePattern).Name}, {typeof(global::G.RepositoryRuleVariant15).Name}, {typeof(global::G.RepositoryRuleVariant16).Name}, {typeof(global::G.RepositoryRuleVariant17).Name}, {typeof(global::G.RepositoryRuleVariant18).Name}, {typeof(global::G.RepositoryRuleWorkflows).Name}, {typeof(global::G.RepositoryRuleCodeScanning).Name}>");
            }

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCreation>(ref reader, options);
            }

            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleUpdate>(ref reader, options);
            }

            else if (value3 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleDeletion>(ref reader, options);
            }

            else if (value4 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredLinearHistory>(ref reader, options);
            }

            else if (value5 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredDeployments>(ref reader, options);
            }

            else if (value6 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredSignatures>(ref reader, options);
            }

            else if (value7 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRulePullRequest>(ref reader, options);
            }

            else if (value8 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredStatusChecks>(ref reader, options);
            }

            else if (value9 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleNonFastForward>(ref reader, options);
            }

            else if (value10 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitMessagePattern>(ref reader, options);
            }

            else if (value11 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitAuthorEmailPattern>(ref reader, options);
            }

            else if (value12 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitterEmailPattern>(ref reader, options);
            }

            else if (value13 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleBranchNamePattern>(ref reader, options);
            }

            else if (value14 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleTagNamePattern>(ref reader, options);
            }

            else if (value15 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleVariant15>(ref reader, options);
            }

            else if (value16 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleVariant16>(ref reader, options);
            }

            else if (value17 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleVariant17>(ref reader, options);
            }

            else if (value18 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleVariant18>(ref reader, options);
            }

            else if (value19 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleWorkflows>(ref reader, options);
            }

            else if (value20 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCodeScanning>(ref reader, options);
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

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::G.RepositoryRuleCreation).Name}, {typeof(global::G.RepositoryRuleUpdate).Name}, {typeof(global::G.RepositoryRuleDeletion).Name}, {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}, {typeof(global::G.RepositoryRuleRequiredDeployments).Name}, {typeof(global::G.RepositoryRuleRequiredSignatures).Name}, {typeof(global::G.RepositoryRulePullRequest).Name}, {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}, {typeof(global::G.RepositoryRuleNonFastForward).Name}, {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}, {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}, {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}, {typeof(global::G.RepositoryRuleBranchNamePattern).Name}, {typeof(global::G.RepositoryRuleTagNamePattern).Name}, {typeof(global::G.RepositoryRuleVariant15).Name}, {typeof(global::G.RepositoryRuleVariant16).Name}, {typeof(global::G.RepositoryRuleVariant17).Name}, {typeof(global::G.RepositoryRuleVariant18).Name}, {typeof(global::G.RepositoryRuleWorkflows).Name}, {typeof(global::G.RepositoryRuleCodeScanning).Name}> object.");
            }

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::G.RepositoryRuleCreation), options);
            }

            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::G.RepositoryRuleUpdate), options);
            }

            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeof(global::G.RepositoryRuleDeletion), options);
            }

            else if (value.IsValue4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeof(global::G.RepositoryRuleRequiredLinearHistory), options);
            }

            else if (value.IsValue5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeof(global::G.RepositoryRuleRequiredDeployments), options);
            }

            else if (value.IsValue6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeof(global::G.RepositoryRuleRequiredSignatures), options);
            }

            else if (value.IsValue7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeof(global::G.RepositoryRulePullRequest), options);
            }

            else if (value.IsValue8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeof(global::G.RepositoryRuleRequiredStatusChecks), options);
            }

            else if (value.IsValue9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeof(global::G.RepositoryRuleNonFastForward), options);
            }

            else if (value.IsValue10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeof(global::G.RepositoryRuleCommitMessagePattern), options);
            }

            else if (value.IsValue11)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options);
            }

            else if (value.IsValue12)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeof(global::G.RepositoryRuleCommitterEmailPattern), options);
            }

            else if (value.IsValue13)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeof(global::G.RepositoryRuleBranchNamePattern), options);
            }

            else if (value.IsValue14)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeof(global::G.RepositoryRuleTagNamePattern), options);
            }

            else if (value.IsValue15)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, typeof(global::G.RepositoryRuleVariant15), options);
            }

            else if (value.IsValue16)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, typeof(global::G.RepositoryRuleVariant16), options);
            }

            else if (value.IsValue17)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value17, typeof(global::G.RepositoryRuleVariant17), options);
            }

            else if (value.IsValue18)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value18, typeof(global::G.RepositoryRuleVariant18), options);
            }

            else if (value.IsValue19)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value19, typeof(global::G.RepositoryRuleWorkflows), options);
            }

            else if (value.IsValue20)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value20, typeof(global::G.RepositoryRuleCodeScanning), options);
            }
        }
    }
}