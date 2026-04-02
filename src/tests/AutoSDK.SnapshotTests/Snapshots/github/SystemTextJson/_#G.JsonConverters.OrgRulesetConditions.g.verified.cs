//HintName: G.JsonConverters.OrgRulesetConditions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OrgRulesetConditionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OrgRulesetConditions>
    {
        /// <inheritdoc />
        public override global::G.OrgRulesetConditions Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>? repositoryNameAndRefName = default;
            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>? repositoryIdAndRefName = default;
            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>? repositoryPropertyAndRefName = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        repositoryNameAndRefName = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>>(__rawJson, options);
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

                        repositoryIdAndRefName = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>>(__rawJson, options);
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

                        repositoryPropertyAndRefName = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (repositoryNameAndRefName == null && repositoryIdAndRefName == null && repositoryPropertyAndRefName == null)
            {
                try
                {

                    repositoryNameAndRefName = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryIdAndRefName = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    repositoryPropertyAndRefName = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OrgRulesetConditions(
                repositoryNameAndRefName,

                repositoryIdAndRefName,

                repositoryPropertyAndRefName
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OrgRulesetConditions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsRepositoryNameAndRefName)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryNameAndRefName, typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>), options);
            }
            else if (value.IsRepositoryIdAndRefName)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryIdAndRefName, typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>), options);
            }
            else if (value.IsRepositoryPropertyAndRefName)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryPropertyAndRefName, typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>), options);
            }
        }
    }
}