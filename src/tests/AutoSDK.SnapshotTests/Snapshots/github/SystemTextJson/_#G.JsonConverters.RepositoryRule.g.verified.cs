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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("parameters")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("parameters")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("parameters")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("parameters")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("parameters")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("parameters")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("parameters")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("parameters")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("parameters")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("parameters")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("parameters")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("parameters")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("parameters")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("parameters")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("parameters")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("parameters")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
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
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }

            global::G.RepositoryRuleCreation? creation = default;
            global::G.RepositoryRuleUpdate? update = default;
            global::G.RepositoryRuleDeletion? deletion = default;
            global::G.RepositoryRuleRequiredLinearHistory? requiredLinearHistory = default;
            global::G.RepositoryRuleMergeQueue? mergeQueue = default;
            global::G.RepositoryRuleRequiredDeployments? requiredDeployments = default;
            global::G.RepositoryRuleRequiredSignatures? requiredSignatures = default;
            global::G.RepositoryRulePullRequest? pullRequest = default;
            global::G.RepositoryRuleRequiredStatusChecks? requiredStatusChecks = default;
            global::G.RepositoryRuleNonFastForward? nonFastForward = default;
            global::G.RepositoryRuleCommitMessagePattern? commitMessagePattern = default;
            global::G.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern = default;
            global::G.RepositoryRuleCommitterEmailPattern? committerEmailPattern = default;
            global::G.RepositoryRuleBranchNamePattern? branchNamePattern = default;
            global::G.RepositoryRuleTagNamePattern? tagNamePattern = default;
            global::G.RepositoryRuleFilePathRestriction? filePathRestriction = default;
            global::G.RepositoryRuleMaxFilePathLength? maxFilePathLength = default;
            global::G.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction = default;
            global::G.RepositoryRuleMaxFileSize? maxFileSize = default;
            global::G.RepositoryRuleWorkflows? workflows = default;
            global::G.RepositoryRuleCodeScanning? codeScanning = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCreation).Name}");
                        creation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                        update = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                        deletion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                        requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMergeQueue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMergeQueue).Name}");
                        mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                        requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                        requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                        pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                        requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                        nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                        commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                        commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                        committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                        branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                        tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFilePathRestriction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFilePathRestriction).Name}");
                        filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFilePathLength> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFilePathLength).Name}");
                        maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFileExtensionRestriction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFileExtensionRestriction).Name}");
                        fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFileSize> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFileSize).Name}");
                        maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                        workflows = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                        codeScanning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null && workflows == null && codeScanning == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCreation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCreation).Name}");
                    creation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                    update = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                    deletion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                    requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMergeQueue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMergeQueue).Name}");
                    mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                    requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                    requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                    pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                    requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                    nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                    commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                    commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                    committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                    branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                    tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFilePathRestriction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFilePathRestriction).Name}");
                    filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFilePathLength> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFilePathLength).Name}");
                    maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFileExtensionRestriction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFileExtensionRestriction).Name}");
                    fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFileSize> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFileSize).Name}");
                    maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                    workflows = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                    codeScanning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Creation!, typeInfo);
            }
            else if (value.IsUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Update!, typeInfo);
            }
            else if (value.IsDeletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleDeletion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleDeletion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deletion!, typeInfo);
            }
            else if (value.IsRequiredLinearHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredLinearHistory?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredLinearHistory).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredLinearHistory!, typeInfo);
            }
            else if (value.IsMergeQueue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMergeQueue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMergeQueue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MergeQueue!, typeInfo);
            }
            else if (value.IsRequiredDeployments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredDeployments?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredDeployments).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredDeployments!, typeInfo);
            }
            else if (value.IsRequiredSignatures)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredSignatures?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredSignatures).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredSignatures!, typeInfo);
            }
            else if (value.IsPullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRulePullRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRulePullRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequest!, typeInfo);
            }
            else if (value.IsRequiredStatusChecks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleRequiredStatusChecks?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleRequiredStatusChecks).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredStatusChecks!, typeInfo);
            }
            else if (value.IsNonFastForward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleNonFastForward?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleNonFastForward).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NonFastForward!, typeInfo);
            }
            else if (value.IsCommitMessagePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitMessagePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitMessagePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitMessagePattern!, typeInfo);
            }
            else if (value.IsCommitAuthorEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitAuthorEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitAuthorEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitAuthorEmailPattern!, typeInfo);
            }
            else if (value.IsCommitterEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCommitterEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCommitterEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitterEmailPattern!, typeInfo);
            }
            else if (value.IsBranchNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleBranchNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleBranchNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BranchNamePattern!, typeInfo);
            }
            else if (value.IsTagNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleTagNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleTagNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TagNamePattern!, typeInfo);
            }
            else if (value.IsFilePathRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFilePathRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFilePathRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePathRestriction!, typeInfo);
            }
            else if (value.IsMaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFilePathLength?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFilePathLength).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFilePathLength!, typeInfo);
            }
            else if (value.IsFileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleFileExtensionRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleFileExtensionRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileExtensionRestriction!, typeInfo);
            }
            else if (value.IsMaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleMaxFileSize?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleMaxFileSize).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFileSize!, typeInfo);
            }
            else if (value.IsWorkflows)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleWorkflows?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleWorkflows).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Workflows!, typeInfo);
            }
            else if (value.IsCodeScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RepositoryRuleCodeScanning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RepositoryRuleCodeScanning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeScanning!, typeInfo);
            }
        }
    }
}