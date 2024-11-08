//HintName: G.Models.IssueEventForIssue.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Issue Event for Issue
    /// </summary>
    public readonly partial struct IssueEventForIssue : global::System.IEquatable<IssueEventForIssue>
    {
        /// <summary>
        /// Labeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LabeledIssueEvent? Labeled { get; init; }
#else
        public global::G.LabeledIssueEvent? Labeled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Labeled))]
#endif
        public bool IsLabeled => Labeled != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.LabeledIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LabeledIssueEvent?(IssueEventForIssue @this) => @this.Labeled;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.LabeledIssueEvent? value)
        {
            Labeled = value;
        }

        /// <summary>
        /// Unlabeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UnlabeledIssueEvent? Unlabeled { get; init; }
#else
        public global::G.UnlabeledIssueEvent? Unlabeled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unlabeled))]
#endif
        public bool IsUnlabeled => Unlabeled != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.UnlabeledIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UnlabeledIssueEvent?(IssueEventForIssue @this) => @this.Unlabeled;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.UnlabeledIssueEvent? value)
        {
            Unlabeled = value;
        }

        /// <summary>
        /// Assigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssignedIssueEvent? Assigned { get; init; }
#else
        public global::G.AssignedIssueEvent? Assigned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assigned))]
#endif
        public bool IsAssigned => Assigned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.AssignedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssignedIssueEvent?(IssueEventForIssue @this) => @this.Assigned;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.AssignedIssueEvent? value)
        {
            Assigned = value;
        }

        /// <summary>
        /// Unassigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UnassignedIssueEvent? Unassigned { get; init; }
#else
        public global::G.UnassignedIssueEvent? Unassigned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unassigned))]
#endif
        public bool IsUnassigned => Unassigned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.UnassignedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UnassignedIssueEvent?(IssueEventForIssue @this) => @this.Unassigned;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.UnassignedIssueEvent? value)
        {
            Unassigned = value;
        }

        /// <summary>
        /// Milestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MilestonedIssueEvent? Milestoned { get; init; }
#else
        public global::G.MilestonedIssueEvent? Milestoned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Milestoned))]
#endif
        public bool IsMilestoned => Milestoned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.MilestonedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MilestonedIssueEvent?(IssueEventForIssue @this) => @this.Milestoned;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.MilestonedIssueEvent? value)
        {
            Milestoned = value;
        }

        /// <summary>
        /// Demilestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DemilestonedIssueEvent? Demilestoned { get; init; }
#else
        public global::G.DemilestonedIssueEvent? Demilestoned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Demilestoned))]
#endif
        public bool IsDemilestoned => Demilestoned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.DemilestonedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DemilestonedIssueEvent?(IssueEventForIssue @this) => @this.Demilestoned;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.DemilestonedIssueEvent? value)
        {
            Demilestoned = value;
        }

        /// <summary>
        /// Renamed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RenamedIssueEvent? Renamed { get; init; }
#else
        public global::G.RenamedIssueEvent? Renamed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Renamed))]
#endif
        public bool IsRenamed => Renamed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.RenamedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RenamedIssueEvent?(IssueEventForIssue @this) => @this.Renamed;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.RenamedIssueEvent? value)
        {
            Renamed = value;
        }

        /// <summary>
        /// Review Requested Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewRequestedIssueEvent? ReviewRequested { get; init; }
#else
        public global::G.ReviewRequestedIssueEvent? ReviewRequested { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequested))]
#endif
        public bool IsReviewRequested => ReviewRequested != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.ReviewRequestedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewRequestedIssueEvent?(IssueEventForIssue @this) => @this.ReviewRequested;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.ReviewRequestedIssueEvent? value)
        {
            ReviewRequested = value;
        }

        /// <summary>
        /// Review Request Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewRequestRemovedIssueEvent? ReviewRequestRemoved { get; init; }
#else
        public global::G.ReviewRequestRemovedIssueEvent? ReviewRequestRemoved { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestRemoved))]
#endif
        public bool IsReviewRequestRemoved => ReviewRequestRemoved != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.ReviewRequestRemovedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewRequestRemovedIssueEvent?(IssueEventForIssue @this) => @this.ReviewRequestRemoved;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.ReviewRequestRemovedIssueEvent? value)
        {
            ReviewRequestRemoved = value;
        }

        /// <summary>
        /// Review Dismissed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewDismissedIssueEvent? ReviewDismissed { get; init; }
#else
        public global::G.ReviewDismissedIssueEvent? ReviewDismissed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewDismissed))]
#endif
        public bool IsReviewDismissed => ReviewDismissed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.ReviewDismissedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewDismissedIssueEvent?(IssueEventForIssue @this) => @this.ReviewDismissed;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.ReviewDismissedIssueEvent? value)
        {
            ReviewDismissed = value;
        }

        /// <summary>
        /// Locked Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LockedIssueEvent? Locked { get; init; }
#else
        public global::G.LockedIssueEvent? Locked { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Locked))]
#endif
        public bool IsLocked => Locked != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.LockedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LockedIssueEvent?(IssueEventForIssue @this) => @this.Locked;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.LockedIssueEvent? value)
        {
            Locked = value;
        }

        /// <summary>
        /// Added to Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AddedToProjectIssueEvent? AddedToProject { get; init; }
#else
        public global::G.AddedToProjectIssueEvent? AddedToProject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddedToProject))]
#endif
        public bool IsAddedToProject => AddedToProject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.AddedToProjectIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AddedToProjectIssueEvent?(IssueEventForIssue @this) => @this.AddedToProject;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.AddedToProjectIssueEvent? value)
        {
            AddedToProject = value;
        }

        /// <summary>
        /// Moved Column in Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MovedColumnInProjectIssueEvent? MovedColumnInProject { get; init; }
#else
        public global::G.MovedColumnInProjectIssueEvent? MovedColumnInProject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MovedColumnInProject))]
#endif
        public bool IsMovedColumnInProject => MovedColumnInProject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.MovedColumnInProjectIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MovedColumnInProjectIssueEvent?(IssueEventForIssue @this) => @this.MovedColumnInProject;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.MovedColumnInProjectIssueEvent? value)
        {
            MovedColumnInProject = value;
        }

        /// <summary>
        /// Removed from Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RemovedFromProjectIssueEvent? RemovedFromProject { get; init; }
#else
        public global::G.RemovedFromProjectIssueEvent? RemovedFromProject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemovedFromProject))]
#endif
        public bool IsRemovedFromProject => RemovedFromProject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.RemovedFromProjectIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RemovedFromProjectIssueEvent?(IssueEventForIssue @this) => @this.RemovedFromProject;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.RemovedFromProjectIssueEvent? value)
        {
            RemovedFromProject = value;
        }

        /// <summary>
        /// Converted Note to Issue Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConvertedNoteToIssueIssueEvent? ConvertedNoteTo { get; init; }
#else
        public global::G.ConvertedNoteToIssueIssueEvent? ConvertedNoteTo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConvertedNoteTo))]
#endif
        public bool IsConvertedNoteTo => ConvertedNoteTo != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.ConvertedNoteToIssueIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConvertedNoteToIssueIssueEvent?(IssueEventForIssue @this) => @this.ConvertedNoteTo;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.ConvertedNoteToIssueIssueEvent? value)
        {
            ConvertedNoteTo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(
            global::G.LabeledIssueEvent? labeled,
            global::G.UnlabeledIssueEvent? unlabeled,
            global::G.AssignedIssueEvent? assigned,
            global::G.UnassignedIssueEvent? unassigned,
            global::G.MilestonedIssueEvent? milestoned,
            global::G.DemilestonedIssueEvent? demilestoned,
            global::G.RenamedIssueEvent? renamed,
            global::G.ReviewRequestedIssueEvent? reviewRequested,
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemoved,
            global::G.ReviewDismissedIssueEvent? reviewDismissed,
            global::G.LockedIssueEvent? locked,
            global::G.AddedToProjectIssueEvent? addedToProject,
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProject,
            global::G.RemovedFromProjectIssueEvent? removedFromProject,
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteTo
            )
        {
            Labeled = labeled;
            Unlabeled = unlabeled;
            Assigned = assigned;
            Unassigned = unassigned;
            Milestoned = milestoned;
            Demilestoned = demilestoned;
            Renamed = renamed;
            ReviewRequested = reviewRequested;
            ReviewRequestRemoved = reviewRequestRemoved;
            ReviewDismissed = reviewDismissed;
            Locked = locked;
            AddedToProject = addedToProject;
            MovedColumnInProject = movedColumnInProject;
            RemovedFromProject = removedFromProject;
            ConvertedNoteTo = convertedNoteTo;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConvertedNoteTo as object ??
            RemovedFromProject as object ??
            MovedColumnInProject as object ??
            AddedToProject as object ??
            Locked as object ??
            ReviewDismissed as object ??
            ReviewRequestRemoved as object ??
            ReviewRequested as object ??
            Renamed as object ??
            Demilestoned as object ??
            Milestoned as object ??
            Unassigned as object ??
            Assigned as object ??
            Unlabeled as object ??
            Labeled as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLabeled || IsUnlabeled || IsAssigned || IsUnassigned || IsMilestoned || IsDemilestoned || IsRenamed || IsReviewRequested || IsReviewRequestRemoved || IsReviewDismissed || IsLocked || IsAddedToProject || IsMovedColumnInProject || IsRemovedFromProject || IsConvertedNoteTo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LabeledIssueEvent?, TResult>? labeled = null,
            global::System.Func<global::G.UnlabeledIssueEvent?, TResult>? unlabeled = null,
            global::System.Func<global::G.AssignedIssueEvent?, TResult>? assigned = null,
            global::System.Func<global::G.UnassignedIssueEvent?, TResult>? unassigned = null,
            global::System.Func<global::G.MilestonedIssueEvent?, TResult>? milestoned = null,
            global::System.Func<global::G.DemilestonedIssueEvent?, TResult>? demilestoned = null,
            global::System.Func<global::G.RenamedIssueEvent?, TResult>? renamed = null,
            global::System.Func<global::G.ReviewRequestedIssueEvent?, TResult>? reviewRequested = null,
            global::System.Func<global::G.ReviewRequestRemovedIssueEvent?, TResult>? reviewRequestRemoved = null,
            global::System.Func<global::G.ReviewDismissedIssueEvent?, TResult>? reviewDismissed = null,
            global::System.Func<global::G.LockedIssueEvent?, TResult>? locked = null,
            global::System.Func<global::G.AddedToProjectIssueEvent?, TResult>? addedToProject = null,
            global::System.Func<global::G.MovedColumnInProjectIssueEvent?, TResult>? movedColumnInProject = null,
            global::System.Func<global::G.RemovedFromProjectIssueEvent?, TResult>? removedFromProject = null,
            global::System.Func<global::G.ConvertedNoteToIssueIssueEvent?, TResult>? convertedNoteTo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeled && labeled != null)
            {
                return labeled(Labeled!);
            }
            else if (IsUnlabeled && unlabeled != null)
            {
                return unlabeled(Unlabeled!);
            }
            else if (IsAssigned && assigned != null)
            {
                return assigned(Assigned!);
            }
            else if (IsUnassigned && unassigned != null)
            {
                return unassigned(Unassigned!);
            }
            else if (IsMilestoned && milestoned != null)
            {
                return milestoned(Milestoned!);
            }
            else if (IsDemilestoned && demilestoned != null)
            {
                return demilestoned(Demilestoned!);
            }
            else if (IsRenamed && renamed != null)
            {
                return renamed(Renamed!);
            }
            else if (IsReviewRequested && reviewRequested != null)
            {
                return reviewRequested(ReviewRequested!);
            }
            else if (IsReviewRequestRemoved && reviewRequestRemoved != null)
            {
                return reviewRequestRemoved(ReviewRequestRemoved!);
            }
            else if (IsReviewDismissed && reviewDismissed != null)
            {
                return reviewDismissed(ReviewDismissed!);
            }
            else if (IsLocked && locked != null)
            {
                return locked(Locked!);
            }
            else if (IsAddedToProject && addedToProject != null)
            {
                return addedToProject(AddedToProject!);
            }
            else if (IsMovedColumnInProject && movedColumnInProject != null)
            {
                return movedColumnInProject(MovedColumnInProject!);
            }
            else if (IsRemovedFromProject && removedFromProject != null)
            {
                return removedFromProject(RemovedFromProject!);
            }
            else if (IsConvertedNoteTo && convertedNoteTo != null)
            {
                return convertedNoteTo(ConvertedNoteTo!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LabeledIssueEvent?>? labeled = null,
            global::System.Action<global::G.UnlabeledIssueEvent?>? unlabeled = null,
            global::System.Action<global::G.AssignedIssueEvent?>? assigned = null,
            global::System.Action<global::G.UnassignedIssueEvent?>? unassigned = null,
            global::System.Action<global::G.MilestonedIssueEvent?>? milestoned = null,
            global::System.Action<global::G.DemilestonedIssueEvent?>? demilestoned = null,
            global::System.Action<global::G.RenamedIssueEvent?>? renamed = null,
            global::System.Action<global::G.ReviewRequestedIssueEvent?>? reviewRequested = null,
            global::System.Action<global::G.ReviewRequestRemovedIssueEvent?>? reviewRequestRemoved = null,
            global::System.Action<global::G.ReviewDismissedIssueEvent?>? reviewDismissed = null,
            global::System.Action<global::G.LockedIssueEvent?>? locked = null,
            global::System.Action<global::G.AddedToProjectIssueEvent?>? addedToProject = null,
            global::System.Action<global::G.MovedColumnInProjectIssueEvent?>? movedColumnInProject = null,
            global::System.Action<global::G.RemovedFromProjectIssueEvent?>? removedFromProject = null,
            global::System.Action<global::G.ConvertedNoteToIssueIssueEvent?>? convertedNoteTo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeled)
            {
                labeled?.Invoke(Labeled!);
            }
            else if (IsUnlabeled)
            {
                unlabeled?.Invoke(Unlabeled!);
            }
            else if (IsAssigned)
            {
                assigned?.Invoke(Assigned!);
            }
            else if (IsUnassigned)
            {
                unassigned?.Invoke(Unassigned!);
            }
            else if (IsMilestoned)
            {
                milestoned?.Invoke(Milestoned!);
            }
            else if (IsDemilestoned)
            {
                demilestoned?.Invoke(Demilestoned!);
            }
            else if (IsRenamed)
            {
                renamed?.Invoke(Renamed!);
            }
            else if (IsReviewRequested)
            {
                reviewRequested?.Invoke(ReviewRequested!);
            }
            else if (IsReviewRequestRemoved)
            {
                reviewRequestRemoved?.Invoke(ReviewRequestRemoved!);
            }
            else if (IsReviewDismissed)
            {
                reviewDismissed?.Invoke(ReviewDismissed!);
            }
            else if (IsLocked)
            {
                locked?.Invoke(Locked!);
            }
            else if (IsAddedToProject)
            {
                addedToProject?.Invoke(AddedToProject!);
            }
            else if (IsMovedColumnInProject)
            {
                movedColumnInProject?.Invoke(MovedColumnInProject!);
            }
            else if (IsRemovedFromProject)
            {
                removedFromProject?.Invoke(RemovedFromProject!);
            }
            else if (IsConvertedNoteTo)
            {
                convertedNoteTo?.Invoke(ConvertedNoteTo!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Labeled,
                typeof(global::G.LabeledIssueEvent),
                Unlabeled,
                typeof(global::G.UnlabeledIssueEvent),
                Assigned,
                typeof(global::G.AssignedIssueEvent),
                Unassigned,
                typeof(global::G.UnassignedIssueEvent),
                Milestoned,
                typeof(global::G.MilestonedIssueEvent),
                Demilestoned,
                typeof(global::G.DemilestonedIssueEvent),
                Renamed,
                typeof(global::G.RenamedIssueEvent),
                ReviewRequested,
                typeof(global::G.ReviewRequestedIssueEvent),
                ReviewRequestRemoved,
                typeof(global::G.ReviewRequestRemovedIssueEvent),
                ReviewDismissed,
                typeof(global::G.ReviewDismissedIssueEvent),
                Locked,
                typeof(global::G.LockedIssueEvent),
                AddedToProject,
                typeof(global::G.AddedToProjectIssueEvent),
                MovedColumnInProject,
                typeof(global::G.MovedColumnInProjectIssueEvent),
                RemovedFromProject,
                typeof(global::G.RemovedFromProjectIssueEvent),
                ConvertedNoteTo,
                typeof(global::G.ConvertedNoteToIssueIssueEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(IssueEventForIssue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LabeledIssueEvent?>.Default.Equals(Labeled, other.Labeled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UnlabeledIssueEvent?>.Default.Equals(Unlabeled, other.Unlabeled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssignedIssueEvent?>.Default.Equals(Assigned, other.Assigned) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UnassignedIssueEvent?>.Default.Equals(Unassigned, other.Unassigned) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MilestonedIssueEvent?>.Default.Equals(Milestoned, other.Milestoned) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DemilestonedIssueEvent?>.Default.Equals(Demilestoned, other.Demilestoned) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RenamedIssueEvent?>.Default.Equals(Renamed, other.Renamed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewRequestedIssueEvent?>.Default.Equals(ReviewRequested, other.ReviewRequested) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewRequestRemovedIssueEvent?>.Default.Equals(ReviewRequestRemoved, other.ReviewRequestRemoved) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewDismissedIssueEvent?>.Default.Equals(ReviewDismissed, other.ReviewDismissed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LockedIssueEvent?>.Default.Equals(Locked, other.Locked) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AddedToProjectIssueEvent?>.Default.Equals(AddedToProject, other.AddedToProject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MovedColumnInProjectIssueEvent?>.Default.Equals(MovedColumnInProject, other.MovedColumnInProject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RemovedFromProjectIssueEvent?>.Default.Equals(RemovedFromProject, other.RemovedFromProject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConvertedNoteToIssueIssueEvent?>.Default.Equals(ConvertedNoteTo, other.ConvertedNoteTo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IssueEventForIssue obj1, IssueEventForIssue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IssueEventForIssue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IssueEventForIssue obj1, IssueEventForIssue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IssueEventForIssue o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.IssueEventForIssue? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.IssueEventForIssue),
                jsonSerializerContext) as global::G.IssueEventForIssue?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.IssueEventForIssue? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.IssueEventForIssue>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.IssueEventForIssue?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.IssueEventForIssue),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.IssueEventForIssue?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.IssueEventForIssue?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.IssueEventForIssue?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
