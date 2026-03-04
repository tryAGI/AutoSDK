//HintName: G.Models.IssueEventForIssue.g.cs
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
        public global::G.LabeledIssueEvent? LabeledIssueEvent { get; init; }
#else
        public global::G.LabeledIssueEvent? LabeledIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabeledIssueEvent))]
#endif
        public bool IsLabeledIssueEvent => LabeledIssueEvent != null;

        /// <summary>
        /// Unlabeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UnlabeledIssueEvent? UnlabeledIssueEvent { get; init; }
#else
        public global::G.UnlabeledIssueEvent? UnlabeledIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnlabeledIssueEvent))]
#endif
        public bool IsUnlabeledIssueEvent => UnlabeledIssueEvent != null;

        /// <summary>
        /// Assigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssignedIssueEvent? AssignedIssueEvent { get; init; }
#else
        public global::G.AssignedIssueEvent? AssignedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssignedIssueEvent))]
#endif
        public bool IsAssignedIssueEvent => AssignedIssueEvent != null;

        /// <summary>
        /// Unassigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UnassignedIssueEvent? UnassignedIssueEvent { get; init; }
#else
        public global::G.UnassignedIssueEvent? UnassignedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnassignedIssueEvent))]
#endif
        public bool IsUnassignedIssueEvent => UnassignedIssueEvent != null;

        /// <summary>
        /// Milestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MilestonedIssueEvent? MilestonedIssueEvent { get; init; }
#else
        public global::G.MilestonedIssueEvent? MilestonedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MilestonedIssueEvent))]
#endif
        public bool IsMilestonedIssueEvent => MilestonedIssueEvent != null;

        /// <summary>
        /// Demilestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DemilestonedIssueEvent? DemilestonedIssueEvent { get; init; }
#else
        public global::G.DemilestonedIssueEvent? DemilestonedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DemilestonedIssueEvent))]
#endif
        public bool IsDemilestonedIssueEvent => DemilestonedIssueEvent != null;

        /// <summary>
        /// Renamed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RenamedIssueEvent? RenamedIssueEvent { get; init; }
#else
        public global::G.RenamedIssueEvent? RenamedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RenamedIssueEvent))]
#endif
        public bool IsRenamedIssueEvent => RenamedIssueEvent != null;

        /// <summary>
        /// Review Requested Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewRequestedIssueEvent? ReviewRequestedIssueEvent { get; init; }
#else
        public global::G.ReviewRequestedIssueEvent? ReviewRequestedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestedIssueEvent))]
#endif
        public bool IsReviewRequestedIssueEvent => ReviewRequestedIssueEvent != null;

        /// <summary>
        /// Review Request Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedIssueEvent { get; init; }
#else
        public global::G.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestRemovedIssueEvent))]
#endif
        public bool IsReviewRequestRemovedIssueEvent => ReviewRequestRemovedIssueEvent != null;

        /// <summary>
        /// Review Dismissed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewDismissedIssueEvent? ReviewDismissedIssueEvent { get; init; }
#else
        public global::G.ReviewDismissedIssueEvent? ReviewDismissedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewDismissedIssueEvent))]
#endif
        public bool IsReviewDismissedIssueEvent => ReviewDismissedIssueEvent != null;

        /// <summary>
        /// Locked Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LockedIssueEvent? LockedIssueEvent { get; init; }
#else
        public global::G.LockedIssueEvent? LockedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LockedIssueEvent))]
#endif
        public bool IsLockedIssueEvent => LockedIssueEvent != null;

        /// <summary>
        /// Added to Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AddedToProjectIssueEvent? AddedToProjectIssueEvent { get; init; }
#else
        public global::G.AddedToProjectIssueEvent? AddedToProjectIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddedToProjectIssueEvent))]
#endif
        public bool IsAddedToProjectIssueEvent => AddedToProjectIssueEvent != null;

        /// <summary>
        /// Moved Column in Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MovedColumnInProjectIssueEvent? MovedColumnInProjectIssueEvent { get; init; }
#else
        public global::G.MovedColumnInProjectIssueEvent? MovedColumnInProjectIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MovedColumnInProjectIssueEvent))]
#endif
        public bool IsMovedColumnInProjectIssueEvent => MovedColumnInProjectIssueEvent != null;

        /// <summary>
        /// Removed from Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RemovedFromProjectIssueEvent? RemovedFromProjectIssueEvent { get; init; }
#else
        public global::G.RemovedFromProjectIssueEvent? RemovedFromProjectIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemovedFromProjectIssueEvent))]
#endif
        public bool IsRemovedFromProjectIssueEvent => RemovedFromProjectIssueEvent != null;

        /// <summary>
        /// Converted Note to Issue Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConvertedNoteToIssueIssueEvent? ConvertedNoteToIssueIssueEvent { get; init; }
#else
        public global::G.ConvertedNoteToIssueIssueEvent? ConvertedNoteToIssueIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConvertedNoteToIssueIssueEvent))]
#endif
        public bool IsConvertedNoteToIssueIssueEvent => ConvertedNoteToIssueIssueEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.LabeledIssueEvent value) => new IssueEventForIssue((global::G.LabeledIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LabeledIssueEvent?(IssueEventForIssue @this) => @this.LabeledIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.LabeledIssueEvent? value)
        {
            LabeledIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.UnlabeledIssueEvent value) => new IssueEventForIssue((global::G.UnlabeledIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UnlabeledIssueEvent?(IssueEventForIssue @this) => @this.UnlabeledIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.UnlabeledIssueEvent? value)
        {
            UnlabeledIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.AssignedIssueEvent value) => new IssueEventForIssue((global::G.AssignedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssignedIssueEvent?(IssueEventForIssue @this) => @this.AssignedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.AssignedIssueEvent? value)
        {
            AssignedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.UnassignedIssueEvent value) => new IssueEventForIssue((global::G.UnassignedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UnassignedIssueEvent?(IssueEventForIssue @this) => @this.UnassignedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.UnassignedIssueEvent? value)
        {
            UnassignedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.MilestonedIssueEvent value) => new IssueEventForIssue((global::G.MilestonedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MilestonedIssueEvent?(IssueEventForIssue @this) => @this.MilestonedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.MilestonedIssueEvent? value)
        {
            MilestonedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.DemilestonedIssueEvent value) => new IssueEventForIssue((global::G.DemilestonedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DemilestonedIssueEvent?(IssueEventForIssue @this) => @this.DemilestonedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.DemilestonedIssueEvent? value)
        {
            DemilestonedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.RenamedIssueEvent value) => new IssueEventForIssue((global::G.RenamedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RenamedIssueEvent?(IssueEventForIssue @this) => @this.RenamedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.RenamedIssueEvent? value)
        {
            RenamedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.ReviewRequestedIssueEvent value) => new IssueEventForIssue((global::G.ReviewRequestedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewRequestedIssueEvent?(IssueEventForIssue @this) => @this.ReviewRequestedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.ReviewRequestedIssueEvent? value)
        {
            ReviewRequestedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.ReviewRequestRemovedIssueEvent value) => new IssueEventForIssue((global::G.ReviewRequestRemovedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewRequestRemovedIssueEvent?(IssueEventForIssue @this) => @this.ReviewRequestRemovedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.ReviewRequestRemovedIssueEvent? value)
        {
            ReviewRequestRemovedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.ReviewDismissedIssueEvent value) => new IssueEventForIssue((global::G.ReviewDismissedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewDismissedIssueEvent?(IssueEventForIssue @this) => @this.ReviewDismissedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.ReviewDismissedIssueEvent? value)
        {
            ReviewDismissedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.LockedIssueEvent value) => new IssueEventForIssue((global::G.LockedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LockedIssueEvent?(IssueEventForIssue @this) => @this.LockedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.LockedIssueEvent? value)
        {
            LockedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.AddedToProjectIssueEvent value) => new IssueEventForIssue((global::G.AddedToProjectIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AddedToProjectIssueEvent?(IssueEventForIssue @this) => @this.AddedToProjectIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.AddedToProjectIssueEvent? value)
        {
            AddedToProjectIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.MovedColumnInProjectIssueEvent value) => new IssueEventForIssue((global::G.MovedColumnInProjectIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MovedColumnInProjectIssueEvent?(IssueEventForIssue @this) => @this.MovedColumnInProjectIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.MovedColumnInProjectIssueEvent? value)
        {
            MovedColumnInProjectIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.RemovedFromProjectIssueEvent value) => new IssueEventForIssue((global::G.RemovedFromProjectIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RemovedFromProjectIssueEvent?(IssueEventForIssue @this) => @this.RemovedFromProjectIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.RemovedFromProjectIssueEvent? value)
        {
            RemovedFromProjectIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::G.ConvertedNoteToIssueIssueEvent value) => new IssueEventForIssue((global::G.ConvertedNoteToIssueIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConvertedNoteToIssueIssueEvent?(IssueEventForIssue @this) => @this.ConvertedNoteToIssueIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::G.ConvertedNoteToIssueIssueEvent? value)
        {
            ConvertedNoteToIssueIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(
            global::G.LabeledIssueEvent? labeledIssueEvent,
            global::G.UnlabeledIssueEvent? unlabeledIssueEvent,
            global::G.AssignedIssueEvent? assignedIssueEvent,
            global::G.UnassignedIssueEvent? unassignedIssueEvent,
            global::G.MilestonedIssueEvent? milestonedIssueEvent,
            global::G.DemilestonedIssueEvent? demilestonedIssueEvent,
            global::G.RenamedIssueEvent? renamedIssueEvent,
            global::G.ReviewRequestedIssueEvent? reviewRequestedIssueEvent,
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemovedIssueEvent,
            global::G.ReviewDismissedIssueEvent? reviewDismissedIssueEvent,
            global::G.LockedIssueEvent? lockedIssueEvent,
            global::G.AddedToProjectIssueEvent? addedToProjectIssueEvent,
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProjectIssueEvent,
            global::G.RemovedFromProjectIssueEvent? removedFromProjectIssueEvent,
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteToIssueIssueEvent
            )
        {
            LabeledIssueEvent = labeledIssueEvent;
            UnlabeledIssueEvent = unlabeledIssueEvent;
            AssignedIssueEvent = assignedIssueEvent;
            UnassignedIssueEvent = unassignedIssueEvent;
            MilestonedIssueEvent = milestonedIssueEvent;
            DemilestonedIssueEvent = demilestonedIssueEvent;
            RenamedIssueEvent = renamedIssueEvent;
            ReviewRequestedIssueEvent = reviewRequestedIssueEvent;
            ReviewRequestRemovedIssueEvent = reviewRequestRemovedIssueEvent;
            ReviewDismissedIssueEvent = reviewDismissedIssueEvent;
            LockedIssueEvent = lockedIssueEvent;
            AddedToProjectIssueEvent = addedToProjectIssueEvent;
            MovedColumnInProjectIssueEvent = movedColumnInProjectIssueEvent;
            RemovedFromProjectIssueEvent = removedFromProjectIssueEvent;
            ConvertedNoteToIssueIssueEvent = convertedNoteToIssueIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConvertedNoteToIssueIssueEvent as object ??
            RemovedFromProjectIssueEvent as object ??
            MovedColumnInProjectIssueEvent as object ??
            AddedToProjectIssueEvent as object ??
            LockedIssueEvent as object ??
            ReviewDismissedIssueEvent as object ??
            ReviewRequestRemovedIssueEvent as object ??
            ReviewRequestedIssueEvent as object ??
            RenamedIssueEvent as object ??
            DemilestonedIssueEvent as object ??
            MilestonedIssueEvent as object ??
            UnassignedIssueEvent as object ??
            AssignedIssueEvent as object ??
            UnlabeledIssueEvent as object ??
            LabeledIssueEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LabeledIssueEvent?.ToString() ??
            UnlabeledIssueEvent?.ToString() ??
            AssignedIssueEvent?.ToString() ??
            UnassignedIssueEvent?.ToString() ??
            MilestonedIssueEvent?.ToString() ??
            DemilestonedIssueEvent?.ToString() ??
            RenamedIssueEvent?.ToString() ??
            ReviewRequestedIssueEvent?.ToString() ??
            ReviewRequestRemovedIssueEvent?.ToString() ??
            ReviewDismissedIssueEvent?.ToString() ??
            LockedIssueEvent?.ToString() ??
            AddedToProjectIssueEvent?.ToString() ??
            MovedColumnInProjectIssueEvent?.ToString() ??
            RemovedFromProjectIssueEvent?.ToString() ??
            ConvertedNoteToIssueIssueEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLabeledIssueEvent || IsUnlabeledIssueEvent || IsAssignedIssueEvent || IsUnassignedIssueEvent || IsMilestonedIssueEvent || IsDemilestonedIssueEvent || IsRenamedIssueEvent || IsReviewRequestedIssueEvent || IsReviewRequestRemovedIssueEvent || IsReviewDismissedIssueEvent || IsLockedIssueEvent || IsAddedToProjectIssueEvent || IsMovedColumnInProjectIssueEvent || IsRemovedFromProjectIssueEvent || IsConvertedNoteToIssueIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LabeledIssueEvent?, TResult>? labeledIssueEvent = null,
            global::System.Func<global::G.UnlabeledIssueEvent?, TResult>? unlabeledIssueEvent = null,
            global::System.Func<global::G.AssignedIssueEvent?, TResult>? assignedIssueEvent = null,
            global::System.Func<global::G.UnassignedIssueEvent?, TResult>? unassignedIssueEvent = null,
            global::System.Func<global::G.MilestonedIssueEvent?, TResult>? milestonedIssueEvent = null,
            global::System.Func<global::G.DemilestonedIssueEvent?, TResult>? demilestonedIssueEvent = null,
            global::System.Func<global::G.RenamedIssueEvent?, TResult>? renamedIssueEvent = null,
            global::System.Func<global::G.ReviewRequestedIssueEvent?, TResult>? reviewRequestedIssueEvent = null,
            global::System.Func<global::G.ReviewRequestRemovedIssueEvent?, TResult>? reviewRequestRemovedIssueEvent = null,
            global::System.Func<global::G.ReviewDismissedIssueEvent?, TResult>? reviewDismissedIssueEvent = null,
            global::System.Func<global::G.LockedIssueEvent?, TResult>? lockedIssueEvent = null,
            global::System.Func<global::G.AddedToProjectIssueEvent?, TResult>? addedToProjectIssueEvent = null,
            global::System.Func<global::G.MovedColumnInProjectIssueEvent?, TResult>? movedColumnInProjectIssueEvent = null,
            global::System.Func<global::G.RemovedFromProjectIssueEvent?, TResult>? removedFromProjectIssueEvent = null,
            global::System.Func<global::G.ConvertedNoteToIssueIssueEvent?, TResult>? convertedNoteToIssueIssueEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledIssueEvent && labeledIssueEvent != null)
            {
                return labeledIssueEvent(LabeledIssueEvent!);
            }
            else if (IsUnlabeledIssueEvent && unlabeledIssueEvent != null)
            {
                return unlabeledIssueEvent(UnlabeledIssueEvent!);
            }
            else if (IsAssignedIssueEvent && assignedIssueEvent != null)
            {
                return assignedIssueEvent(AssignedIssueEvent!);
            }
            else if (IsUnassignedIssueEvent && unassignedIssueEvent != null)
            {
                return unassignedIssueEvent(UnassignedIssueEvent!);
            }
            else if (IsMilestonedIssueEvent && milestonedIssueEvent != null)
            {
                return milestonedIssueEvent(MilestonedIssueEvent!);
            }
            else if (IsDemilestonedIssueEvent && demilestonedIssueEvent != null)
            {
                return demilestonedIssueEvent(DemilestonedIssueEvent!);
            }
            else if (IsRenamedIssueEvent && renamedIssueEvent != null)
            {
                return renamedIssueEvent(RenamedIssueEvent!);
            }
            else if (IsReviewRequestedIssueEvent && reviewRequestedIssueEvent != null)
            {
                return reviewRequestedIssueEvent(ReviewRequestedIssueEvent!);
            }
            else if (IsReviewRequestRemovedIssueEvent && reviewRequestRemovedIssueEvent != null)
            {
                return reviewRequestRemovedIssueEvent(ReviewRequestRemovedIssueEvent!);
            }
            else if (IsReviewDismissedIssueEvent && reviewDismissedIssueEvent != null)
            {
                return reviewDismissedIssueEvent(ReviewDismissedIssueEvent!);
            }
            else if (IsLockedIssueEvent && lockedIssueEvent != null)
            {
                return lockedIssueEvent(LockedIssueEvent!);
            }
            else if (IsAddedToProjectIssueEvent && addedToProjectIssueEvent != null)
            {
                return addedToProjectIssueEvent(AddedToProjectIssueEvent!);
            }
            else if (IsMovedColumnInProjectIssueEvent && movedColumnInProjectIssueEvent != null)
            {
                return movedColumnInProjectIssueEvent(MovedColumnInProjectIssueEvent!);
            }
            else if (IsRemovedFromProjectIssueEvent && removedFromProjectIssueEvent != null)
            {
                return removedFromProjectIssueEvent(RemovedFromProjectIssueEvent!);
            }
            else if (IsConvertedNoteToIssueIssueEvent && convertedNoteToIssueIssueEvent != null)
            {
                return convertedNoteToIssueIssueEvent(ConvertedNoteToIssueIssueEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LabeledIssueEvent?>? labeledIssueEvent = null,
            global::System.Action<global::G.UnlabeledIssueEvent?>? unlabeledIssueEvent = null,
            global::System.Action<global::G.AssignedIssueEvent?>? assignedIssueEvent = null,
            global::System.Action<global::G.UnassignedIssueEvent?>? unassignedIssueEvent = null,
            global::System.Action<global::G.MilestonedIssueEvent?>? milestonedIssueEvent = null,
            global::System.Action<global::G.DemilestonedIssueEvent?>? demilestonedIssueEvent = null,
            global::System.Action<global::G.RenamedIssueEvent?>? renamedIssueEvent = null,
            global::System.Action<global::G.ReviewRequestedIssueEvent?>? reviewRequestedIssueEvent = null,
            global::System.Action<global::G.ReviewRequestRemovedIssueEvent?>? reviewRequestRemovedIssueEvent = null,
            global::System.Action<global::G.ReviewDismissedIssueEvent?>? reviewDismissedIssueEvent = null,
            global::System.Action<global::G.LockedIssueEvent?>? lockedIssueEvent = null,
            global::System.Action<global::G.AddedToProjectIssueEvent?>? addedToProjectIssueEvent = null,
            global::System.Action<global::G.MovedColumnInProjectIssueEvent?>? movedColumnInProjectIssueEvent = null,
            global::System.Action<global::G.RemovedFromProjectIssueEvent?>? removedFromProjectIssueEvent = null,
            global::System.Action<global::G.ConvertedNoteToIssueIssueEvent?>? convertedNoteToIssueIssueEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledIssueEvent)
            {
                labeledIssueEvent?.Invoke(LabeledIssueEvent!);
            }
            else if (IsUnlabeledIssueEvent)
            {
                unlabeledIssueEvent?.Invoke(UnlabeledIssueEvent!);
            }
            else if (IsAssignedIssueEvent)
            {
                assignedIssueEvent?.Invoke(AssignedIssueEvent!);
            }
            else if (IsUnassignedIssueEvent)
            {
                unassignedIssueEvent?.Invoke(UnassignedIssueEvent!);
            }
            else if (IsMilestonedIssueEvent)
            {
                milestonedIssueEvent?.Invoke(MilestonedIssueEvent!);
            }
            else if (IsDemilestonedIssueEvent)
            {
                demilestonedIssueEvent?.Invoke(DemilestonedIssueEvent!);
            }
            else if (IsRenamedIssueEvent)
            {
                renamedIssueEvent?.Invoke(RenamedIssueEvent!);
            }
            else if (IsReviewRequestedIssueEvent)
            {
                reviewRequestedIssueEvent?.Invoke(ReviewRequestedIssueEvent!);
            }
            else if (IsReviewRequestRemovedIssueEvent)
            {
                reviewRequestRemovedIssueEvent?.Invoke(ReviewRequestRemovedIssueEvent!);
            }
            else if (IsReviewDismissedIssueEvent)
            {
                reviewDismissedIssueEvent?.Invoke(ReviewDismissedIssueEvent!);
            }
            else if (IsLockedIssueEvent)
            {
                lockedIssueEvent?.Invoke(LockedIssueEvent!);
            }
            else if (IsAddedToProjectIssueEvent)
            {
                addedToProjectIssueEvent?.Invoke(AddedToProjectIssueEvent!);
            }
            else if (IsMovedColumnInProjectIssueEvent)
            {
                movedColumnInProjectIssueEvent?.Invoke(MovedColumnInProjectIssueEvent!);
            }
            else if (IsRemovedFromProjectIssueEvent)
            {
                removedFromProjectIssueEvent?.Invoke(RemovedFromProjectIssueEvent!);
            }
            else if (IsConvertedNoteToIssueIssueEvent)
            {
                convertedNoteToIssueIssueEvent?.Invoke(ConvertedNoteToIssueIssueEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LabeledIssueEvent,
                typeof(global::G.LabeledIssueEvent),
                UnlabeledIssueEvent,
                typeof(global::G.UnlabeledIssueEvent),
                AssignedIssueEvent,
                typeof(global::G.AssignedIssueEvent),
                UnassignedIssueEvent,
                typeof(global::G.UnassignedIssueEvent),
                MilestonedIssueEvent,
                typeof(global::G.MilestonedIssueEvent),
                DemilestonedIssueEvent,
                typeof(global::G.DemilestonedIssueEvent),
                RenamedIssueEvent,
                typeof(global::G.RenamedIssueEvent),
                ReviewRequestedIssueEvent,
                typeof(global::G.ReviewRequestedIssueEvent),
                ReviewRequestRemovedIssueEvent,
                typeof(global::G.ReviewRequestRemovedIssueEvent),
                ReviewDismissedIssueEvent,
                typeof(global::G.ReviewDismissedIssueEvent),
                LockedIssueEvent,
                typeof(global::G.LockedIssueEvent),
                AddedToProjectIssueEvent,
                typeof(global::G.AddedToProjectIssueEvent),
                MovedColumnInProjectIssueEvent,
                typeof(global::G.MovedColumnInProjectIssueEvent),
                RemovedFromProjectIssueEvent,
                typeof(global::G.RemovedFromProjectIssueEvent),
                ConvertedNoteToIssueIssueEvent,
                typeof(global::G.ConvertedNoteToIssueIssueEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(IssueEventForIssue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LabeledIssueEvent?>.Default.Equals(LabeledIssueEvent, other.LabeledIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UnlabeledIssueEvent?>.Default.Equals(UnlabeledIssueEvent, other.UnlabeledIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssignedIssueEvent?>.Default.Equals(AssignedIssueEvent, other.AssignedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UnassignedIssueEvent?>.Default.Equals(UnassignedIssueEvent, other.UnassignedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MilestonedIssueEvent?>.Default.Equals(MilestonedIssueEvent, other.MilestonedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DemilestonedIssueEvent?>.Default.Equals(DemilestonedIssueEvent, other.DemilestonedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RenamedIssueEvent?>.Default.Equals(RenamedIssueEvent, other.RenamedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewRequestedIssueEvent?>.Default.Equals(ReviewRequestedIssueEvent, other.ReviewRequestedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewRequestRemovedIssueEvent?>.Default.Equals(ReviewRequestRemovedIssueEvent, other.ReviewRequestRemovedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewDismissedIssueEvent?>.Default.Equals(ReviewDismissedIssueEvent, other.ReviewDismissedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LockedIssueEvent?>.Default.Equals(LockedIssueEvent, other.LockedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AddedToProjectIssueEvent?>.Default.Equals(AddedToProjectIssueEvent, other.AddedToProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MovedColumnInProjectIssueEvent?>.Default.Equals(MovedColumnInProjectIssueEvent, other.MovedColumnInProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RemovedFromProjectIssueEvent?>.Default.Equals(RemovedFromProjectIssueEvent, other.RemovedFromProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConvertedNoteToIssueIssueEvent?>.Default.Equals(ConvertedNoteToIssueIssueEvent, other.ConvertedNoteToIssueIssueEvent) 
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
    }
}
