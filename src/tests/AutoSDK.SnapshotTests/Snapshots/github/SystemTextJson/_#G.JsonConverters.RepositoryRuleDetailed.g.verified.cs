//HintName: G.JsonConverters.RepositoryRuleDetailed.g.cs
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


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            var __score5 = 0;
            var __score6 = 0;
            var __score7 = 0;
            var __score8 = 0;
            var __score9 = 0;
            var __score10 = 0;
            var __score11 = 0;
            var __score12 = 0;
            var __score13 = 0;
            var __score14 = 0;
            var __score15 = 0;
            var __score16 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }

            global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant1 = default;
            global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant2 = default;
            global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant3 = default;
            global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant4 = default;
            global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant5 = default;
            global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant6 = default;
            global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant7 = default;
            global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant8 = default;
            global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant9 = default;
            global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant10 = default;
            global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant11 = default;
            global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant12 = default;
            global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant13 = default;
            global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant14 = default;
            global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant15 = default;
            global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant16 = default;
            global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant17 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        repositoryRuleDetailedVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        repositoryRuleDetailedVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        repositoryRuleDetailedVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        repositoryRuleDetailedVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        repositoryRuleDetailedVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 5)
                {
                    try
                    {

                        repositoryRuleDetailedVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 6)
                {
                    try
                    {

                        repositoryRuleDetailedVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 7)
                {
                    try
                    {

                        repositoryRuleDetailedVariant8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 8)
                {
                    try
                    {

                        repositoryRuleDetailedVariant9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 9)
                {
                    try
                    {

                        repositoryRuleDetailedVariant10 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 10)
                {
                    try
                    {

                        repositoryRuleDetailedVariant11 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 11)
                {
                    try
                    {

                        repositoryRuleDetailedVariant12 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 12)
                {
                    try
                    {

                        repositoryRuleDetailedVariant13 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 13)
                {
                    try
                    {

                        repositoryRuleDetailedVariant14 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 14)
                {
                    try
                    {

                        repositoryRuleDetailedVariant15 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 15)
                {
                    try
                    {

                        repositoryRuleDetailedVariant16 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 16)
                {
                    try
                    {

                        repositoryRuleDetailedVariant17 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (repositoryRuleDetailedVariant1 == null && repositoryRuleDetailedVariant2 == null && repositoryRuleDetailedVariant3 == null && repositoryRuleDetailedVariant4 == null && repositoryRuleDetailedVariant5 == null && repositoryRuleDetailedVariant6 == null && repositoryRuleDetailedVariant7 == null && repositoryRuleDetailedVariant8 == null && repositoryRuleDetailedVariant9 == null && repositoryRuleDetailedVariant10 == null && repositoryRuleDetailedVariant11 == null && repositoryRuleDetailedVariant12 == null && repositoryRuleDetailedVariant13 == null && repositoryRuleDetailedVariant14 == null && repositoryRuleDetailedVariant15 == null && repositoryRuleDetailedVariant16 == null && repositoryRuleDetailedVariant17 == null)
            {
                try
                {

                    repositoryRuleDetailedVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant7 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant8 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant9 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant10 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant11 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant12 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant13 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant14 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant15 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant16 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryRuleDetailedVariant17 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RepositoryRuleDetailed(
                repositoryRuleDetailedVariant1,

                repositoryRuleDetailedVariant2,

                repositoryRuleDetailedVariant3,

                repositoryRuleDetailedVariant4,

                repositoryRuleDetailedVariant5,

                repositoryRuleDetailedVariant6,

                repositoryRuleDetailedVariant7,

                repositoryRuleDetailedVariant8,

                repositoryRuleDetailedVariant9,

                repositoryRuleDetailedVariant10,

                repositoryRuleDetailedVariant11,

                repositoryRuleDetailedVariant12,

                repositoryRuleDetailedVariant13,

                repositoryRuleDetailedVariant14,

                repositoryRuleDetailedVariant15,

                repositoryRuleDetailedVariant16,

                repositoryRuleDetailedVariant17
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryRuleDetailed value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsRepositoryRuleDetailedVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant1, typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant2, typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant3, typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant4, typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant5, typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant6, typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant7)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant7, typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant8)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant8, typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant9)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant9, typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant10)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant10, typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant11)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant11, typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant12)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant12, typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant13)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant13, typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant14)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant14, typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant15)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant15, typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant16)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant16, typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>), options);
            }
            else if (value.IsRepositoryRuleDetailedVariant17)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDetailedVariant17, typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>), options);
            }
        }
    }
}