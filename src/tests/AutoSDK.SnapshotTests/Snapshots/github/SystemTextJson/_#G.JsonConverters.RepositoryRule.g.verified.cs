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
                        creation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCreation>(__rawJson, options);
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
                        update = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleUpdate>(__rawJson, options);
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
                        deletion = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleDeletion>(__rawJson, options);
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
                        requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredLinearHistory>(__rawJson, options);
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
                        mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleMergeQueue>(__rawJson, options);
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
                        requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredDeployments>(__rawJson, options);
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
                        requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredSignatures>(__rawJson, options);
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
                        pullRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRulePullRequest>(__rawJson, options);
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
                        requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredStatusChecks>(__rawJson, options);
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
                        nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleNonFastForward>(__rawJson, options);
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
                        commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitMessagePattern>(__rawJson, options);
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
                        commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitAuthorEmailPattern>(__rawJson, options);
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
                        committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitterEmailPattern>(__rawJson, options);
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
                        branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleBranchNamePattern>(__rawJson, options);
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
                        tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleTagNamePattern>(__rawJson, options);
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
                        filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleFilePathRestriction>(__rawJson, options);
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
                        maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleMaxFilePathLength>(__rawJson, options);
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
                        fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleFileExtensionRestriction>(__rawJson, options);
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
                        maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleMaxFileSize>(__rawJson, options);
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
                        workflows = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleWorkflows>(__rawJson, options);
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
                        codeScanning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCodeScanning>(__rawJson, options);
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
                    creation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCreation>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    update = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleUpdate>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    deletion = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleDeletion>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredLinearHistory>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleMergeQueue>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredDeployments>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredSignatures>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    pullRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRulePullRequest>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRequiredStatusChecks>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleNonFastForward>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitMessagePattern>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitAuthorEmailPattern>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCommitterEmailPattern>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleBranchNamePattern>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleTagNamePattern>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleFilePathRestriction>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleMaxFilePathLength>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleFileExtensionRestriction>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleMaxFileSize>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    workflows = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleWorkflows>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    codeScanning = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleCodeScanning>(__rawJson, options);
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

            if (value.IsCreation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Creation, typeof(global::G.RepositoryRuleCreation), options);
            }
            else if (value.IsUpdate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Update, typeof(global::G.RepositoryRuleUpdate), options);
            }
            else if (value.IsDeletion)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deletion, typeof(global::G.RepositoryRuleDeletion), options);
            }
            else if (value.IsRequiredLinearHistory)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredLinearHistory, typeof(global::G.RepositoryRuleRequiredLinearHistory), options);
            }
            else if (value.IsMergeQueue)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MergeQueue, typeof(global::G.RepositoryRuleMergeQueue), options);
            }
            else if (value.IsRequiredDeployments)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredDeployments, typeof(global::G.RepositoryRuleRequiredDeployments), options);
            }
            else if (value.IsRequiredSignatures)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredSignatures, typeof(global::G.RepositoryRuleRequiredSignatures), options);
            }
            else if (value.IsPullRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequest, typeof(global::G.RepositoryRulePullRequest), options);
            }
            else if (value.IsRequiredStatusChecks)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredStatusChecks, typeof(global::G.RepositoryRuleRequiredStatusChecks), options);
            }
            else if (value.IsNonFastForward)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NonFastForward, typeof(global::G.RepositoryRuleNonFastForward), options);
            }
            else if (value.IsCommitMessagePattern)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitMessagePattern, typeof(global::G.RepositoryRuleCommitMessagePattern), options);
            }
            else if (value.IsCommitAuthorEmailPattern)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitAuthorEmailPattern, typeof(global::G.RepositoryRuleCommitAuthorEmailPattern), options);
            }
            else if (value.IsCommitterEmailPattern)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitterEmailPattern, typeof(global::G.RepositoryRuleCommitterEmailPattern), options);
            }
            else if (value.IsBranchNamePattern)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BranchNamePattern, typeof(global::G.RepositoryRuleBranchNamePattern), options);
            }
            else if (value.IsTagNamePattern)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TagNamePattern, typeof(global::G.RepositoryRuleTagNamePattern), options);
            }
            else if (value.IsFilePathRestriction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePathRestriction, typeof(global::G.RepositoryRuleFilePathRestriction), options);
            }
            else if (value.IsMaxFilePathLength)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFilePathLength, typeof(global::G.RepositoryRuleMaxFilePathLength), options);
            }
            else if (value.IsFileExtensionRestriction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileExtensionRestriction, typeof(global::G.RepositoryRuleFileExtensionRestriction), options);
            }
            else if (value.IsMaxFileSize)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFileSize, typeof(global::G.RepositoryRuleMaxFileSize), options);
            }
            else if (value.IsWorkflows)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Workflows, typeof(global::G.RepositoryRuleWorkflows), options);
            }
            else if (value.IsCodeScanning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeScanning, typeof(global::G.RepositoryRuleCodeScanning), options);
            }
        }
    }
}