//HintName: G.JsonConverters.IssueEventForIssue.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class IssueEventForIssueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.IssueEventForIssue>
    {
        /// <inheritdoc />
        public override global::G.IssueEventForIssue Read(
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
            global::G.AssignedIssueEvent? assignedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssignedIssueEvent).Name}");
                assignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UnassignedIssueEvent? unassignedIssueEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnassignedIssueEvent).Name}");
                unassignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
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

            var __value = new global::G.IssueEventForIssue(
                labeledIssueEvent,

                unlabeledIssueEvent,

                assignedIssueEvent,

                unassignedIssueEvent,

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

                convertedNoteToIssueIssueEvent
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
            else if (assignedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (unassignedIssueEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnassignedIssueEvent).Name}");
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

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.IssueEventForIssue value,
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
            else if (value.IsAssignedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssignedIssueEvent, typeInfo);
            }
            else if (value.IsUnassignedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnassignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnassignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnassignedIssueEvent, typeInfo);
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
        }
    }
}