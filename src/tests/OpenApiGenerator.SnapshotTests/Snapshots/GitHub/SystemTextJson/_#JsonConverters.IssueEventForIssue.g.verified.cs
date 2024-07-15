//HintName: JsonConverters.IssueEventForIssue.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::G.LabeledIssueEvent? labeled = default;
            try
            {
                labeled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LabeledIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UnlabeledIssueEvent? unlabeled = default;
            try
            {
                unlabeled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnlabeledIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AssignedIssueEvent? assigned = default;
            try
            {
                assigned = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssignedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UnassignedIssueEvent? unassigned = default;
            try
            {
                unassigned = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnassignedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MilestonedIssueEvent? milestoned = default;
            try
            {
                milestoned = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MilestonedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DemilestonedIssueEvent? demilestoned = default;
            try
            {
                demilestoned = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DemilestonedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RenamedIssueEvent? renamed = default;
            try
            {
                renamed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RenamedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewRequestedIssueEvent? reviewRequested = default;
            try
            {
                reviewRequested = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemoved = default;
            try
            {
                reviewRequestRemoved = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestRemovedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReviewDismissedIssueEvent? reviewDismissed = default;
            try
            {
                reviewDismissed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewDismissedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.LockedIssueEvent? locked = default;
            try
            {
                locked = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LockedIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AddedToProjectIssueEvent? addedToProject = default;
            try
            {
                addedToProject = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AddedToProjectIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProject = default;
            try
            {
                movedColumnInProject = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MovedColumnInProjectIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RemovedFromProjectIssueEvent? removedFromProject = default;
            try
            {
                removedFromProject = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RemovedFromProjectIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteTo = default;
            try
            {
                convertedNoteTo = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConvertedNoteToIssueIssueEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::G.IssueEventForIssue(
                labeled,

                unlabeled,

                assigned,

                unassigned,

                milestoned,

                demilestoned,

                renamed,

                reviewRequested,

                reviewRequestRemoved,

                reviewDismissed,

                locked,

                addedToProject,

                movedColumnInProject,

                removedFromProject,

                convertedNoteTo
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for AnyOf<{typeof(global::G.LabeledIssueEvent).Name}, {typeof(global::G.UnlabeledIssueEvent).Name}, {typeof(global::G.AssignedIssueEvent).Name}, {typeof(global::G.UnassignedIssueEvent).Name}, {typeof(global::G.MilestonedIssueEvent).Name}, {typeof(global::G.DemilestonedIssueEvent).Name}, {typeof(global::G.RenamedIssueEvent).Name}, {typeof(global::G.ReviewRequestedIssueEvent).Name}, {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}, {typeof(global::G.ReviewDismissedIssueEvent).Name}, {typeof(global::G.LockedIssueEvent).Name}, {typeof(global::G.AddedToProjectIssueEvent).Name}, {typeof(global::G.MovedColumnInProjectIssueEvent).Name}, {typeof(global::G.RemovedFromProjectIssueEvent).Name}, {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}>");
            }

            if (labeled != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LabeledIssueEvent>(ref reader, options);
            }

            else if (unlabeled != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnlabeledIssueEvent>(ref reader, options);
            }

            else if (assigned != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssignedIssueEvent>(ref reader, options);
            }

            else if (unassigned != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnassignedIssueEvent>(ref reader, options);
            }

            else if (milestoned != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MilestonedIssueEvent>(ref reader, options);
            }

            else if (demilestoned != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DemilestonedIssueEvent>(ref reader, options);
            }

            else if (renamed != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RenamedIssueEvent>(ref reader, options);
            }

            else if (reviewRequested != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestedIssueEvent>(ref reader, options);
            }

            else if (reviewRequestRemoved != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewRequestRemovedIssueEvent>(ref reader, options);
            }

            else if (reviewDismissed != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReviewDismissedIssueEvent>(ref reader, options);
            }

            else if (locked != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LockedIssueEvent>(ref reader, options);
            }

            else if (addedToProject != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AddedToProjectIssueEvent>(ref reader, options);
            }

            else if (movedColumnInProject != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MovedColumnInProjectIssueEvent>(ref reader, options);
            }

            else if (removedFromProject != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RemovedFromProjectIssueEvent>(ref reader, options);
            }

            else if (convertedNoteTo != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConvertedNoteToIssueIssueEvent>(ref reader, options);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.IssueEventForIssue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid AnyOf<{typeof(global::G.LabeledIssueEvent).Name}, {typeof(global::G.UnlabeledIssueEvent).Name}, {typeof(global::G.AssignedIssueEvent).Name}, {typeof(global::G.UnassignedIssueEvent).Name}, {typeof(global::G.MilestonedIssueEvent).Name}, {typeof(global::G.DemilestonedIssueEvent).Name}, {typeof(global::G.RenamedIssueEvent).Name}, {typeof(global::G.ReviewRequestedIssueEvent).Name}, {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}, {typeof(global::G.ReviewDismissedIssueEvent).Name}, {typeof(global::G.LockedIssueEvent).Name}, {typeof(global::G.AddedToProjectIssueEvent).Name}, {typeof(global::G.MovedColumnInProjectIssueEvent).Name}, {typeof(global::G.RemovedFromProjectIssueEvent).Name}, {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}> object.");
            }

            if (value.IsLabeled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Labeled, typeof(global::G.LabeledIssueEvent), options);
            }

            else if (value.IsUnlabeled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unlabeled, typeof(global::G.UnlabeledIssueEvent), options);
            }

            else if (value.IsAssigned)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assigned, typeof(global::G.AssignedIssueEvent), options);
            }

            else if (value.IsUnassigned)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unassigned, typeof(global::G.UnassignedIssueEvent), options);
            }

            else if (value.IsMilestoned)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Milestoned, typeof(global::G.MilestonedIssueEvent), options);
            }

            else if (value.IsDemilestoned)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Demilestoned, typeof(global::G.DemilestonedIssueEvent), options);
            }

            else if (value.IsRenamed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Renamed, typeof(global::G.RenamedIssueEvent), options);
            }

            else if (value.IsReviewRequested)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequested, typeof(global::G.ReviewRequestedIssueEvent), options);
            }

            else if (value.IsReviewRequestRemoved)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemoved, typeof(global::G.ReviewRequestRemovedIssueEvent), options);
            }

            else if (value.IsReviewDismissed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissed, typeof(global::G.ReviewDismissedIssueEvent), options);
            }

            else if (value.IsLocked)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Locked, typeof(global::G.LockedIssueEvent), options);
            }

            else if (value.IsAddedToProject)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProject, typeof(global::G.AddedToProjectIssueEvent), options);
            }

            else if (value.IsMovedColumnInProject)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProject, typeof(global::G.MovedColumnInProjectIssueEvent), options);
            }

            else if (value.IsRemovedFromProject)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProject, typeof(global::G.RemovedFromProjectIssueEvent), options);
            }

            else if (value.IsConvertedNoteTo)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteTo, typeof(global::G.ConvertedNoteToIssueIssueEvent), options);
            }
        }
    }
}