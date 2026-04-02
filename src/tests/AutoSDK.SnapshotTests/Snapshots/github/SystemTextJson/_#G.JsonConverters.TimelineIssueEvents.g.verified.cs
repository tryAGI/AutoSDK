//HintName: G.JsonConverters.TimelineIssueEvents.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TimelineIssueEventsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TimelineIssueEvents>
    {
        /// <inheritdoc />
        public override global::G.TimelineIssueEvents Read(
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
            if (__jsonProps.Contains("actor")) __score0++;
            if (__jsonProps.Contains("commit_id")) __score0++;
            if (__jsonProps.Contains("commit_url")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("event")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("label")) __score0++;
            if (__jsonProps.Contains("node_id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("actor")) __score1++;
            if (__jsonProps.Contains("commit_id")) __score1++;
            if (__jsonProps.Contains("commit_url")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("event")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("label")) __score1++;
            if (__jsonProps.Contains("node_id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("actor")) __score2++;
            if (__jsonProps.Contains("commit_id")) __score2++;
            if (__jsonProps.Contains("commit_url")) __score2++;
            if (__jsonProps.Contains("created_at")) __score2++;
            if (__jsonProps.Contains("event")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("milestone")) __score2++;
            if (__jsonProps.Contains("node_id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app")) __score2++;
            if (__jsonProps.Contains("url")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("actor")) __score3++;
            if (__jsonProps.Contains("commit_id")) __score3++;
            if (__jsonProps.Contains("commit_url")) __score3++;
            if (__jsonProps.Contains("created_at")) __score3++;
            if (__jsonProps.Contains("event")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("milestone")) __score3++;
            if (__jsonProps.Contains("node_id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app")) __score3++;
            if (__jsonProps.Contains("url")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("actor")) __score4++;
            if (__jsonProps.Contains("commit_id")) __score4++;
            if (__jsonProps.Contains("commit_url")) __score4++;
            if (__jsonProps.Contains("created_at")) __score4++;
            if (__jsonProps.Contains("event")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("node_id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app")) __score4++;
            if (__jsonProps.Contains("rename")) __score4++;
            if (__jsonProps.Contains("url")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("actor")) __score5++;
            if (__jsonProps.Contains("commit_id")) __score5++;
            if (__jsonProps.Contains("commit_url")) __score5++;
            if (__jsonProps.Contains("created_at")) __score5++;
            if (__jsonProps.Contains("event")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("node_id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app")) __score5++;
            if (__jsonProps.Contains("requested_reviewer")) __score5++;
            if (__jsonProps.Contains("requested_team")) __score5++;
            if (__jsonProps.Contains("review_requester")) __score5++;
            if (__jsonProps.Contains("url")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("actor")) __score6++;
            if (__jsonProps.Contains("commit_id")) __score6++;
            if (__jsonProps.Contains("commit_url")) __score6++;
            if (__jsonProps.Contains("created_at")) __score6++;
            if (__jsonProps.Contains("event")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("node_id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app")) __score6++;
            if (__jsonProps.Contains("requested_reviewer")) __score6++;
            if (__jsonProps.Contains("requested_team")) __score6++;
            if (__jsonProps.Contains("review_requester")) __score6++;
            if (__jsonProps.Contains("url")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("actor")) __score7++;
            if (__jsonProps.Contains("commit_id")) __score7++;
            if (__jsonProps.Contains("commit_url")) __score7++;
            if (__jsonProps.Contains("created_at")) __score7++;
            if (__jsonProps.Contains("dismissed_review")) __score7++;
            if (__jsonProps.Contains("event")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("node_id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app")) __score7++;
            if (__jsonProps.Contains("url")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("actor")) __score8++;
            if (__jsonProps.Contains("commit_id")) __score8++;
            if (__jsonProps.Contains("commit_url")) __score8++;
            if (__jsonProps.Contains("created_at")) __score8++;
            if (__jsonProps.Contains("event")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("lock_reason")) __score8++;
            if (__jsonProps.Contains("node_id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app")) __score8++;
            if (__jsonProps.Contains("url")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("actor")) __score9++;
            if (__jsonProps.Contains("commit_id")) __score9++;
            if (__jsonProps.Contains("commit_url")) __score9++;
            if (__jsonProps.Contains("created_at")) __score9++;
            if (__jsonProps.Contains("event")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("node_id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app")) __score9++;
            if (__jsonProps.Contains("project_card")) __score9++;
            if (__jsonProps.Contains("url")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("actor")) __score10++;
            if (__jsonProps.Contains("commit_id")) __score10++;
            if (__jsonProps.Contains("commit_url")) __score10++;
            if (__jsonProps.Contains("created_at")) __score10++;
            if (__jsonProps.Contains("event")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("node_id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app")) __score10++;
            if (__jsonProps.Contains("project_card")) __score10++;
            if (__jsonProps.Contains("url")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("actor")) __score11++;
            if (__jsonProps.Contains("commit_id")) __score11++;
            if (__jsonProps.Contains("commit_url")) __score11++;
            if (__jsonProps.Contains("created_at")) __score11++;
            if (__jsonProps.Contains("event")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("node_id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app")) __score11++;
            if (__jsonProps.Contains("project_card")) __score11++;
            if (__jsonProps.Contains("url")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("actor")) __score12++;
            if (__jsonProps.Contains("commit_id")) __score12++;
            if (__jsonProps.Contains("commit_url")) __score12++;
            if (__jsonProps.Contains("created_at")) __score12++;
            if (__jsonProps.Contains("event")) __score12++;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("node_id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app")) __score12++;
            if (__jsonProps.Contains("project_card")) __score12++;
            if (__jsonProps.Contains("url")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("actor")) __score13++;
            if (__jsonProps.Contains("author_association")) __score13++;
            if (__jsonProps.Contains("body")) __score13++;
            if (__jsonProps.Contains("body_html")) __score13++;
            if (__jsonProps.Contains("body_text")) __score13++;
            if (__jsonProps.Contains("created_at")) __score13++;
            if (__jsonProps.Contains("event")) __score13++;
            if (__jsonProps.Contains("html_url")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("issue_url")) __score13++;
            if (__jsonProps.Contains("node_id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app")) __score13++;
            if (__jsonProps.Contains("reactions")) __score13++;
            if (__jsonProps.Contains("updated_at")) __score13++;
            if (__jsonProps.Contains("url")) __score13++;
            if (__jsonProps.Contains("user")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("actor")) __score14++;
            if (__jsonProps.Contains("created_at")) __score14++;
            if (__jsonProps.Contains("event")) __score14++;
            if (__jsonProps.Contains("source")) __score14++;
            if (__jsonProps.Contains("updated_at")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("author")) __score15++;
            if (__jsonProps.Contains("committer")) __score15++;
            if (__jsonProps.Contains("event")) __score15++;
            if (__jsonProps.Contains("html_url")) __score15++;
            if (__jsonProps.Contains("message")) __score15++;
            if (__jsonProps.Contains("node_id")) __score15++;
            if (__jsonProps.Contains("parents")) __score15++;
            if (__jsonProps.Contains("sha")) __score15++;
            if (__jsonProps.Contains("tree")) __score15++;
            if (__jsonProps.Contains("url")) __score15++;
            if (__jsonProps.Contains("verification")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("_links")) __score16++;
            if (__jsonProps.Contains("author_association")) __score16++;
            if (__jsonProps.Contains("body")) __score16++;
            if (__jsonProps.Contains("body_html")) __score16++;
            if (__jsonProps.Contains("body_text")) __score16++;
            if (__jsonProps.Contains("commit_id")) __score16++;
            if (__jsonProps.Contains("event")) __score16++;
            if (__jsonProps.Contains("html_url")) __score16++;
            if (__jsonProps.Contains("id")) __score16++;
            if (__jsonProps.Contains("node_id")) __score16++;
            if (__jsonProps.Contains("pull_request_url")) __score16++;
            if (__jsonProps.Contains("state")) __score16++;
            if (__jsonProps.Contains("submitted_at")) __score16++;
            if (__jsonProps.Contains("user")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("comments")) __score17++;
            if (__jsonProps.Contains("event")) __score17++;
            if (__jsonProps.Contains("node_id")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("comments")) __score18++;
            if (__jsonProps.Contains("commit_id")) __score18++;
            if (__jsonProps.Contains("event")) __score18++;
            if (__jsonProps.Contains("node_id")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("actor")) __score19++;
            if (__jsonProps.Contains("assignee")) __score19++;
            if (__jsonProps.Contains("commit_id")) __score19++;
            if (__jsonProps.Contains("commit_url")) __score19++;
            if (__jsonProps.Contains("created_at")) __score19++;
            if (__jsonProps.Contains("event")) __score19++;
            if (__jsonProps.Contains("id")) __score19++;
            if (__jsonProps.Contains("node_id")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app")) __score19++;
            if (__jsonProps.Contains("url")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("actor")) __score20++;
            if (__jsonProps.Contains("assignee")) __score20++;
            if (__jsonProps.Contains("commit_id")) __score20++;
            if (__jsonProps.Contains("commit_url")) __score20++;
            if (__jsonProps.Contains("created_at")) __score20++;
            if (__jsonProps.Contains("event")) __score20++;
            if (__jsonProps.Contains("id")) __score20++;
            if (__jsonProps.Contains("node_id")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app")) __score20++;
            if (__jsonProps.Contains("url")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("actor")) __score21++;
            if (__jsonProps.Contains("commit_id")) __score21++;
            if (__jsonProps.Contains("commit_url")) __score21++;
            if (__jsonProps.Contains("created_at")) __score21++;
            if (__jsonProps.Contains("event")) __score21++;
            if (__jsonProps.Contains("id")) __score21++;
            if (__jsonProps.Contains("node_id")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app")) __score21++;
            if (__jsonProps.Contains("state_reason")) __score21++;
            if (__jsonProps.Contains("url")) __score21++;
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
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }

            global::G.LabeledIssueEvent? labeledIssueEvent = default;
            global::G.UnlabeledIssueEvent? unlabeledIssueEvent = default;
            global::G.MilestonedIssueEvent? milestonedIssueEvent = default;
            global::G.DemilestonedIssueEvent? demilestonedIssueEvent = default;
            global::G.RenamedIssueEvent? renamedIssueEvent = default;
            global::G.ReviewRequestedIssueEvent? reviewRequestedIssueEvent = default;
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemovedIssueEvent = default;
            global::G.ReviewDismissedIssueEvent? reviewDismissedIssueEvent = default;
            global::G.LockedIssueEvent? lockedIssueEvent = default;
            global::G.AddedToProjectIssueEvent? addedToProjectIssueEvent = default;
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProjectIssueEvent = default;
            global::G.RemovedFromProjectIssueEvent? removedFromProjectIssueEvent = default;
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteToIssueIssueEvent = default;
            global::G.TimelineCommentEvent? timelineCommentEvent = default;
            global::G.TimelineCrossReferencedEvent? timelineCrossReferencedEvent = default;
            global::G.TimelineCommittedEvent? timelineCommittedEvent = default;
            global::G.TimelineReviewedEvent? timelineReviewedEvent = default;
            global::G.TimelineLineCommentedEvent? timelineLineCommentedEvent = default;
            global::G.TimelineCommitCommentedEvent? timelineCommitCommentedEvent = default;
            global::G.TimelineAssignedIssueEvent? timelineAssignedIssueEvent = default;
            global::G.TimelineUnassignedIssueEvent? timelineUnassignedIssueEvent = default;
            global::G.StateChangeIssueEvent? stateChangeIssueEvent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        labeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LabeledIssueEvent>(__rawJson, options);
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
                        unlabeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnlabeledIssueEvent>(__rawJson, options);
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
                        milestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MilestonedIssueEvent>(__rawJson, options);
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
                        demilestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DemilestonedIssueEvent>(__rawJson, options);
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
                        renamedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RenamedIssueEvent>(__rawJson, options);
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
                        reviewRequestedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestedIssueEvent>(__rawJson, options);
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
                        reviewRequestRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestRemovedIssueEvent>(__rawJson, options);
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
                        reviewDismissedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewDismissedIssueEvent>(__rawJson, options);
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
                        lockedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LockedIssueEvent>(__rawJson, options);
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
                        addedToProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AddedToProjectIssueEvent>(__rawJson, options);
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
                        movedColumnInProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MovedColumnInProjectIssueEvent>(__rawJson, options);
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
                        removedFromProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RemovedFromProjectIssueEvent>(__rawJson, options);
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
                        convertedNoteToIssueIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConvertedNoteToIssueIssueEvent>(__rawJson, options);
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
                        timelineCommentEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommentEvent>(__rawJson, options);
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
                        timelineCrossReferencedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCrossReferencedEvent>(__rawJson, options);
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
                        timelineCommittedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommittedEvent>(__rawJson, options);
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
                        timelineReviewedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineReviewedEvent>(__rawJson, options);
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
                        timelineLineCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineLineCommentedEvent>(__rawJson, options);
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
                        timelineCommitCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommitCommentedEvent>(__rawJson, options);
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
                        timelineAssignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineAssignedIssueEvent>(__rawJson, options);
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
                        timelineUnassignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineUnassignedIssueEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        stateChangeIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StateChangeIssueEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && timelineCommentEvent == null && timelineCrossReferencedEvent == null && timelineCommittedEvent == null && timelineReviewedEvent == null && timelineLineCommentedEvent == null && timelineCommitCommentedEvent == null && timelineAssignedIssueEvent == null && timelineUnassignedIssueEvent == null && stateChangeIssueEvent == null)
            {
                try
                {
                    labeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LabeledIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    unlabeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnlabeledIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    milestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MilestonedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    demilestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DemilestonedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    renamedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RenamedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    reviewRequestedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    reviewRequestRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestRemovedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    reviewDismissedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewDismissedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lockedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LockedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    addedToProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AddedToProjectIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    movedColumnInProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MovedColumnInProjectIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    removedFromProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RemovedFromProjectIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    convertedNoteToIssueIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConvertedNoteToIssueIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    timelineCommentEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommentEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    timelineCrossReferencedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCrossReferencedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    timelineCommittedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommittedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    timelineReviewedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineReviewedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    timelineLineCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineLineCommentedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    timelineCommitCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommitCommentedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    timelineAssignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineAssignedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    timelineUnassignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineUnassignedIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    stateChangeIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StateChangeIssueEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TimelineIssueEvents(
                labeledIssueEvent,

                unlabeledIssueEvent,

                milestonedIssueEvent,

                demilestonedIssueEvent,

                renamedIssueEvent,

                reviewRequestedIssueEvent,

                reviewRequestRemovedIssueEvent,

                reviewDismissedIssueEvent,

                lockedIssueEvent,

                addedToProjectIssueEvent,

                movedColumnInProjectIssueEvent,

                removedFromProjectIssueEvent,

                convertedNoteToIssueIssueEvent,

                timelineCommentEvent,

                timelineCrossReferencedEvent,

                timelineCommittedEvent,

                timelineReviewedEvent,

                timelineLineCommentedEvent,

                timelineCommitCommentedEvent,

                timelineAssignedIssueEvent,

                timelineUnassignedIssueEvent,

                stateChangeIssueEvent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TimelineIssueEvents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLabeledIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LabeledIssueEvent, typeof(global::G.LabeledIssueEvent), options);
            }
            else if (value.IsUnlabeledIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnlabeledIssueEvent, typeof(global::G.UnlabeledIssueEvent), options);
            }
            else if (value.IsMilestonedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MilestonedIssueEvent, typeof(global::G.MilestonedIssueEvent), options);
            }
            else if (value.IsDemilestonedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DemilestonedIssueEvent, typeof(global::G.DemilestonedIssueEvent), options);
            }
            else if (value.IsRenamedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RenamedIssueEvent, typeof(global::G.RenamedIssueEvent), options);
            }
            else if (value.IsReviewRequestedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestedIssueEvent, typeof(global::G.ReviewRequestedIssueEvent), options);
            }
            else if (value.IsReviewRequestRemovedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemovedIssueEvent, typeof(global::G.ReviewRequestRemovedIssueEvent), options);
            }
            else if (value.IsReviewDismissedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissedIssueEvent, typeof(global::G.ReviewDismissedIssueEvent), options);
            }
            else if (value.IsLockedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LockedIssueEvent, typeof(global::G.LockedIssueEvent), options);
            }
            else if (value.IsAddedToProjectIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProjectIssueEvent, typeof(global::G.AddedToProjectIssueEvent), options);
            }
            else if (value.IsMovedColumnInProjectIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProjectIssueEvent, typeof(global::G.MovedColumnInProjectIssueEvent), options);
            }
            else if (value.IsRemovedFromProjectIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProjectIssueEvent, typeof(global::G.RemovedFromProjectIssueEvent), options);
            }
            else if (value.IsConvertedNoteToIssueIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteToIssueIssueEvent, typeof(global::G.ConvertedNoteToIssueIssueEvent), options);
            }
            else if (value.IsTimelineCommentEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineCommentEvent, typeof(global::G.TimelineCommentEvent), options);
            }
            else if (value.IsTimelineCrossReferencedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineCrossReferencedEvent, typeof(global::G.TimelineCrossReferencedEvent), options);
            }
            else if (value.IsTimelineCommittedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineCommittedEvent, typeof(global::G.TimelineCommittedEvent), options);
            }
            else if (value.IsTimelineReviewedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineReviewedEvent, typeof(global::G.TimelineReviewedEvent), options);
            }
            else if (value.IsTimelineLineCommentedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineLineCommentedEvent, typeof(global::G.TimelineLineCommentedEvent), options);
            }
            else if (value.IsTimelineCommitCommentedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineCommitCommentedEvent, typeof(global::G.TimelineCommitCommentedEvent), options);
            }
            else if (value.IsTimelineAssignedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineAssignedIssueEvent, typeof(global::G.TimelineAssignedIssueEvent), options);
            }
            else if (value.IsTimelineUnassignedIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineUnassignedIssueEvent, typeof(global::G.TimelineUnassignedIssueEvent), options);
            }
            else if (value.IsStateChangeIssueEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StateChangeIssueEvent, typeof(global::G.StateChangeIssueEvent), options);
            }
        }
    }
}