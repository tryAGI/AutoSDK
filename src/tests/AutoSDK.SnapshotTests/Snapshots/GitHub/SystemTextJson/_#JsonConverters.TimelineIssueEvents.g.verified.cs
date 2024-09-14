//HintName: JsonConverters.TimelineIssueEvents.g.cs
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.LabeledIssueEvent? labeledEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                labeledEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UnlabeledIssueEvent? unlabeledEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                unlabeledEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MilestonedIssueEvent? milestonedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                milestonedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DemilestonedIssueEvent? demilestonedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                demilestonedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RenamedIssueEvent? renamedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                renamedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewRequestedIssueEvent? reviewRequestedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                reviewRequestedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemovedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                reviewRequestRemovedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewDismissedIssueEvent? reviewDismissedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                reviewDismissedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.LockedIssueEvent? lockedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                lockedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AddedToProjectIssueEvent? addedToProjectEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                addedToProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProjectEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                movedColumnInProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RemovedFromProjectIssueEvent? removedFromProjectEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                removedFromProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteToEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                convertedNoteToEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommentEvent? commentEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommentEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommentEvent).Name}");
                commentEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCrossReferencedEvent? crossReferencedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCrossReferencedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCrossReferencedEvent).Name}");
                crossReferencedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommittedEvent? committedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommittedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommittedEvent).Name}");
                committedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineReviewedEvent? reviewedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineReviewedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineReviewedEvent).Name}");
                reviewedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineLineCommentedEvent? lineCommentedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineLineCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineLineCommentedEvent).Name}");
                lineCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommitCommentedEvent? commitCommentedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommitCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommitCommentedEvent).Name}");
                commitCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineAssignedIssueEvent? assignedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineAssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineAssignedIssueEvent).Name}");
                assignedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineUnassignedIssueEvent? unassignedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineUnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineUnassignedIssueEvent).Name}");
                unassignedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.StateChangeIssueEvent? stateChangeEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateChangeIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateChangeIssueEvent).Name}");
                stateChangeEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (unlabeledEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (milestonedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (demilestonedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (renamedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reviewRequestedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reviewRequestRemovedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reviewDismissedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (lockedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (addedToProjectEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (movedColumnInProjectEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (removedFromProjectEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (convertedNoteToEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (commentEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommentEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommentEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (crossReferencedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCrossReferencedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCrossReferencedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (committedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommittedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommittedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reviewedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineReviewedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineReviewedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (lineCommentedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineLineCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineLineCommentedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (commitCommentedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommitCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommitCommentedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (assignedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineAssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineAssignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (unassignedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineUnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineUnassignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (stateChangeEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateChangeIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateChangeIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLabeledEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LabeledEvent, typeInfo);
            }
            else if (value.IsUnlabeledEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnlabeledEvent, typeInfo);
            }
            else if (value.IsMilestonedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MilestonedEvent, typeInfo);
            }
            else if (value.IsDemilestonedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DemilestonedEvent, typeInfo);
            }
            else if (value.IsRenamedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RenamedEvent, typeInfo);
            }
            else if (value.IsReviewRequestedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestedEvent, typeInfo);
            }
            else if (value.IsReviewRequestRemovedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemovedEvent, typeInfo);
            }
            else if (value.IsReviewDismissedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissedEvent, typeInfo);
            }
            else if (value.IsLockedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LockedEvent, typeInfo);
            }
            else if (value.IsAddedToProjectEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProjectEvent, typeInfo);
            }
            else if (value.IsMovedColumnInProjectEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProjectEvent, typeInfo);
            }
            else if (value.IsRemovedFromProjectEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProjectEvent, typeInfo);
            }
            else if (value.IsConvertedNoteToEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteToEvent, typeInfo);
            }
            else if (value.IsCommentEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommentEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommentEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommentEvent, typeInfo);
            }
            else if (value.IsCrossReferencedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCrossReferencedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCrossReferencedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CrossReferencedEvent, typeInfo);
            }
            else if (value.IsCommittedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommittedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommittedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommittedEvent, typeInfo);
            }
            else if (value.IsReviewedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineReviewedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineReviewedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewedEvent, typeInfo);
            }
            else if (value.IsLineCommentedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineLineCommentedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineLineCommentedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LineCommentedEvent, typeInfo);
            }
            else if (value.IsCommitCommentedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommitCommentedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommitCommentedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitCommentedEvent, typeInfo);
            }
            else if (value.IsAssignedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineAssignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineAssignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssignedEvent, typeInfo);
            }
            else if (value.IsUnassignedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineUnassignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineUnassignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnassignedEvent, typeInfo);
            }
            else if (value.IsStateChangeEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateChangeIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateChangeIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StateChangeEvent, typeInfo);
            }
        }
    }
}