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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __score5 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
                    }
                }
            }
            var __score6 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score6++;
                    }
                }
            }
            var __score7 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score7++;
                    }
                }
            }
            var __score8 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score8++;
                    }
                }
            }
            var __score9 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score9++;
                    }
                }
            }
            var __score10 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score10++;
                    }
                }
            }
            var __score11 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score11++;
                    }
                }
            }
            var __score12 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score12++;
                    }
                }
            }
            var __score13 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score13++;
                    }
                }
            }
            var __score14 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score14++;
                    }
                }
            }
            var __score15 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score15++;
                    }
                }
            }
            var __score16 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score16++;
                    }
                }
            }
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

            global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>? value1 = default;
            global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>? value2 = default;
            global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>? value3 = default;
            global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>? value4 = default;
            global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>? value5 = default;
            global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>? value6 = default;
            global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>? value7 = default;
            global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>? value8 = default;
            global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>? value9 = default;
            global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>? value10 = default;
            global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>? value11 = default;
            global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>? value12 = default;
            global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>? value13 = default;
            global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>? value14 = default;
            global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>? value15 = default;
            global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>? value16 = default;
            global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>? value17 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>).Name}");
                        value17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null && value5 == null && value6 == null && value7 == null && value8 == null && value9 == null && value10 == null && value11 == null && value12 == null && value13 == null && value14 == null && value15 == null && value16 == null && value17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>).Name}");
                    value17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RepositoryRuleDetailed(
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

            return __value;
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