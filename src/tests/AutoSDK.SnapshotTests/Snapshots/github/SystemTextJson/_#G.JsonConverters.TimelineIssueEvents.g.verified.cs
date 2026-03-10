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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.LabeledIssueEvent? labeledIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                labeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UnlabeledIssueEvent? unlabeledIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                unlabeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MilestonedIssueEvent? milestonedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                milestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DemilestonedIssueEvent? demilestonedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                demilestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RenamedIssueEvent? renamedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                renamedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewRequestedIssueEvent? reviewRequestedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                reviewRequestedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemovedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                reviewRequestRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewDismissedIssueEvent? reviewDismissedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                reviewDismissedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.LockedIssueEvent? lockedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                lockedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AddedToProjectIssueEvent? addedToProjectIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                addedToProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProjectIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                movedColumnInProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RemovedFromProjectIssueEvent? removedFromProjectIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                removedFromProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteToIssueIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                convertedNoteToIssueIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommentEvent? timelineCommentEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommentEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommentEvent).Name}");
                timelineCommentEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCrossReferencedEvent? timelineCrossReferencedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCrossReferencedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCrossReferencedEvent).Name}");
                timelineCrossReferencedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommittedEvent? timelineCommittedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommittedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommittedEvent).Name}");
                timelineCommittedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineReviewedEvent? timelineReviewedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineReviewedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineReviewedEvent).Name}");
                timelineReviewedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineLineCommentedEvent? timelineLineCommentedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineLineCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineLineCommentedEvent).Name}");
                timelineLineCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineCommitCommentedEvent? timelineCommitCommentedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommitCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommitCommentedEvent).Name}");
                timelineCommitCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineAssignedIssueEvent? timelineAssignedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineAssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineAssignedIssueEvent).Name}");
                timelineAssignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TimelineUnassignedIssueEvent? timelineUnassignedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineUnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineUnassignedIssueEvent).Name}");
                timelineUnassignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.StateChangeIssueEvent? stateChangeIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateChangeIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateChangeIssueEvent).Name}");
                stateChangeIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
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

            if (labeledIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (unlabeledIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (milestonedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (demilestonedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (renamedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reviewRequestedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reviewRequestRemovedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reviewDismissedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (lockedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (addedToProjectIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (movedColumnInProjectIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (removedFromProjectIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (convertedNoteToIssueIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (timelineCommentEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommentEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommentEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (timelineCrossReferencedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCrossReferencedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCrossReferencedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (timelineCommittedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommittedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommittedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (timelineReviewedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineReviewedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineReviewedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (timelineLineCommentedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineLineCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineLineCommentedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (timelineCommitCommentedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommitCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommitCommentedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (timelineAssignedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineAssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineAssignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (timelineUnassignedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineUnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineUnassignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (stateChangeIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateChangeIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateChangeIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TimelineIssueEvents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLabeledIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LabeledIssueEvent, typeInfo);
            }
            else if (value.IsUnlabeledIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnlabeledIssueEvent, typeInfo);
            }
            else if (value.IsMilestonedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MilestonedIssueEvent, typeInfo);
            }
            else if (value.IsDemilestonedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DemilestonedIssueEvent, typeInfo);
            }
            else if (value.IsRenamedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RenamedIssueEvent, typeInfo);
            }
            else if (value.IsReviewRequestedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestedIssueEvent, typeInfo);
            }
            else if (value.IsReviewRequestRemovedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemovedIssueEvent, typeInfo);
            }
            else if (value.IsReviewDismissedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissedIssueEvent, typeInfo);
            }
            else if (value.IsLockedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LockedIssueEvent, typeInfo);
            }
            else if (value.IsAddedToProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProjectIssueEvent, typeInfo);
            }
            else if (value.IsMovedColumnInProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProjectIssueEvent, typeInfo);
            }
            else if (value.IsRemovedFromProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProjectIssueEvent, typeInfo);
            }
            else if (value.IsConvertedNoteToIssueIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteToIssueIssueEvent, typeInfo);
            }
            else if (value.IsTimelineCommentEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommentEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommentEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineCommentEvent, typeInfo);
            }
            else if (value.IsTimelineCrossReferencedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCrossReferencedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCrossReferencedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineCrossReferencedEvent, typeInfo);
            }
            else if (value.IsTimelineCommittedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommittedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommittedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineCommittedEvent, typeInfo);
            }
            else if (value.IsTimelineReviewedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineReviewedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineReviewedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineReviewedEvent, typeInfo);
            }
            else if (value.IsTimelineLineCommentedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineLineCommentedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineLineCommentedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineLineCommentedEvent, typeInfo);
            }
            else if (value.IsTimelineCommitCommentedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineCommitCommentedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineCommitCommentedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineCommitCommentedEvent, typeInfo);
            }
            else if (value.IsTimelineAssignedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineAssignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineAssignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineAssignedIssueEvent, typeInfo);
            }
            else if (value.IsTimelineUnassignedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TimelineUnassignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TimelineUnassignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimelineUnassignedIssueEvent, typeInfo);
            }
            else if (value.IsStateChangeIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateChangeIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateChangeIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StateChangeIssueEvent, typeInfo);
            }
        }
    }
}