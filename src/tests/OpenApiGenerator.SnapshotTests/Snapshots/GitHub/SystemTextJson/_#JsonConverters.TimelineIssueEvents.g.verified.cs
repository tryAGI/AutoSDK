//HintName: JsonConverters.TimelineIssueEvents.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::G.LabeledIssueEvent? labeledEvent = default;
            try
            {
                labeledEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LabeledIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UnlabeledIssueEvent? unlabeledEvent = default;
            try
            {
                unlabeledEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnlabeledIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MilestonedIssueEvent? milestonedEvent = default;
            try
            {
                milestonedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MilestonedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DemilestonedIssueEvent? demilestonedEvent = default;
            try
            {
                demilestonedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DemilestonedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RenamedIssueEvent? renamedEvent = default;
            try
            {
                renamedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RenamedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewRequestedIssueEvent? reviewRequestedEvent = default;
            try
            {
                reviewRequestedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemovedEvent = default;
            try
            {
                reviewRequestRemovedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestRemovedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewDismissedIssueEvent? reviewDismissedEvent = default;
            try
            {
                reviewDismissedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewDismissedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.LockedIssueEvent? lockedEvent = default;
            try
            {
                lockedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LockedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AddedToProjectIssueEvent? addedToProjectEvent = default;
            try
            {
                addedToProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AddedToProjectIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProjectEvent = default;
            try
            {
                movedColumnInProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MovedColumnInProjectIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RemovedFromProjectIssueEvent? removedFromProjectEvent = default;
            try
            {
                removedFromProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RemovedFromProjectIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteToEvent = default;
            try
            {
                convertedNoteToEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConvertedNoteToIssueIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommentEvent? commentEvent = default;
            try
            {
                commentEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommentEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCrossReferencedEvent? crossReferencedEvent = default;
            try
            {
                crossReferencedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCrossReferencedEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommittedEvent? committedEvent = default;
            try
            {
                committedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommittedEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineReviewedEvent? reviewedEvent = default;
            try
            {
                reviewedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineReviewedEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineLineCommentedEvent? lineCommentedEvent = default;
            try
            {
                lineCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineLineCommentedEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommitCommentedEvent? commitCommentedEvent = default;
            try
            {
                commitCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommitCommentedEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineAssignedIssueEvent? assignedEvent = default;
            try
            {
                assignedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineAssignedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineUnassignedIssueEvent? unassignedEvent = default;
            try
            {
                unassignedEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineUnassignedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.StateChangeIssueEvent? stateChangeEvent = default;
            try
            {
                stateChangeEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StateChangeIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.TimelineIssueEvents(
                labeledEvent,
                unlabeledEvent,
                milestonedEvent,
                demilestonedEvent,
                renamedEvent,
                reviewRequestedEvent,
                reviewRequestRemovedEvent,
                reviewDismissedEvent,
                lockedEvent,
                addedToProjectEvent,
                movedColumnInProjectEvent,
                removedFromProjectEvent,
                convertedNoteToEvent,
                commentEvent,
                crossReferencedEvent,
                committedEvent,
                reviewedEvent,
                lineCommentedEvent,
                commitCommentedEvent,
                assignedEvent,
                unassignedEvent,
                stateChangeEvent
                );

            if (labeledEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LabeledIssueEvent>(ref reader, options);
            }
            else if (unlabeledEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnlabeledIssueEvent>(ref reader, options);
            }
            else if (milestonedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MilestonedIssueEvent>(ref reader, options);
            }
            else if (demilestonedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DemilestonedIssueEvent>(ref reader, options);
            }
            else if (renamedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RenamedIssueEvent>(ref reader, options);
            }
            else if (reviewRequestedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestedIssueEvent>(ref reader, options);
            }
            else if (reviewRequestRemovedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestRemovedIssueEvent>(ref reader, options);
            }
            else if (reviewDismissedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewDismissedIssueEvent>(ref reader, options);
            }
            else if (lockedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LockedIssueEvent>(ref reader, options);
            }
            else if (addedToProjectEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AddedToProjectIssueEvent>(ref reader, options);
            }
            else if (movedColumnInProjectEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MovedColumnInProjectIssueEvent>(ref reader, options);
            }
            else if (removedFromProjectEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RemovedFromProjectIssueEvent>(ref reader, options);
            }
            else if (convertedNoteToEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConvertedNoteToIssueIssueEvent>(ref reader, options);
            }
            else if (commentEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommentEvent>(ref reader, options);
            }
            else if (crossReferencedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCrossReferencedEvent>(ref reader, options);
            }
            else if (committedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommittedEvent>(ref reader, options);
            }
            else if (reviewedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineReviewedEvent>(ref reader, options);
            }
            else if (lineCommentedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineLineCommentedEvent>(ref reader, options);
            }
            else if (commitCommentedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineCommitCommentedEvent>(ref reader, options);
            }
            else if (assignedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineAssignedIssueEvent>(ref reader, options);
            }
            else if (unassignedEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TimelineUnassignedIssueEvent>(ref reader, options);
            }
            else if (stateChangeEvent != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StateChangeIssueEvent>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TimelineIssueEvents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLabeledEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LabeledEvent, typeof(global::G.LabeledIssueEvent), options);
            }
            else if (value.IsUnlabeledEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnlabeledEvent, typeof(global::G.UnlabeledIssueEvent), options);
            }
            else if (value.IsMilestonedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MilestonedEvent, typeof(global::G.MilestonedIssueEvent), options);
            }
            else if (value.IsDemilestonedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DemilestonedEvent, typeof(global::G.DemilestonedIssueEvent), options);
            }
            else if (value.IsRenamedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RenamedEvent, typeof(global::G.RenamedIssueEvent), options);
            }
            else if (value.IsReviewRequestedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestedEvent, typeof(global::G.ReviewRequestedIssueEvent), options);
            }
            else if (value.IsReviewRequestRemovedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemovedEvent, typeof(global::G.ReviewRequestRemovedIssueEvent), options);
            }
            else if (value.IsReviewDismissedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissedEvent, typeof(global::G.ReviewDismissedIssueEvent), options);
            }
            else if (value.IsLockedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LockedEvent, typeof(global::G.LockedIssueEvent), options);
            }
            else if (value.IsAddedToProjectEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProjectEvent, typeof(global::G.AddedToProjectIssueEvent), options);
            }
            else if (value.IsMovedColumnInProjectEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProjectEvent, typeof(global::G.MovedColumnInProjectIssueEvent), options);
            }
            else if (value.IsRemovedFromProjectEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProjectEvent, typeof(global::G.RemovedFromProjectIssueEvent), options);
            }
            else if (value.IsConvertedNoteToEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteToEvent, typeof(global::G.ConvertedNoteToIssueIssueEvent), options);
            }
            else if (value.IsCommentEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommentEvent, typeof(global::G.TimelineCommentEvent), options);
            }
            else if (value.IsCrossReferencedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CrossReferencedEvent, typeof(global::G.TimelineCrossReferencedEvent), options);
            }
            else if (value.IsCommittedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommittedEvent, typeof(global::G.TimelineCommittedEvent), options);
            }
            else if (value.IsReviewedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewedEvent, typeof(global::G.TimelineReviewedEvent), options);
            }
            else if (value.IsLineCommentedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LineCommentedEvent, typeof(global::G.TimelineLineCommentedEvent), options);
            }
            else if (value.IsCommitCommentedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitCommentedEvent, typeof(global::G.TimelineCommitCommentedEvent), options);
            }
            else if (value.IsAssignedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssignedEvent, typeof(global::G.TimelineAssignedIssueEvent), options);
            }
            else if (value.IsUnassignedEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnassignedEvent, typeof(global::G.TimelineUnassignedIssueEvent), options);
            }
            else if (value.IsStateChangeEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StateChangeEvent, typeof(global::G.StateChangeIssueEvent), options);
            }
        }
    }
}