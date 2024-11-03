//HintName: G.Models.TimelineIssueEvents.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Event
    /// </summary>
    public readonly partial struct TimelineIssueEvents : global::System.IEquatable<TimelineIssueEvents>
    {
        /// <summary>
        /// Labeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LabeledIssueEvent? LabeledEvent { get; init; }
#else
        public global::G.LabeledIssueEvent? LabeledEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabeledEvent))]
#endif
        public bool IsLabeledEvent => LabeledEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.LabeledIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LabeledIssueEvent?(TimelineIssueEvents @this) => @this.LabeledEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.LabeledIssueEvent? value)
        {
            LabeledEvent = value;
        }

        /// <summary>
        /// Unlabeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UnlabeledIssueEvent? UnlabeledEvent { get; init; }
#else
        public global::G.UnlabeledIssueEvent? UnlabeledEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnlabeledEvent))]
#endif
        public bool IsUnlabeledEvent => UnlabeledEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.UnlabeledIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UnlabeledIssueEvent?(TimelineIssueEvents @this) => @this.UnlabeledEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.UnlabeledIssueEvent? value)
        {
            UnlabeledEvent = value;
        }

        /// <summary>
        /// Milestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MilestonedIssueEvent? MilestonedEvent { get; init; }
#else
        public global::G.MilestonedIssueEvent? MilestonedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MilestonedEvent))]
#endif
        public bool IsMilestonedEvent => MilestonedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.MilestonedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MilestonedIssueEvent?(TimelineIssueEvents @this) => @this.MilestonedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.MilestonedIssueEvent? value)
        {
            MilestonedEvent = value;
        }

        /// <summary>
        /// Demilestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DemilestonedIssueEvent? DemilestonedEvent { get; init; }
#else
        public global::G.DemilestonedIssueEvent? DemilestonedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DemilestonedEvent))]
#endif
        public bool IsDemilestonedEvent => DemilestonedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.DemilestonedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DemilestonedIssueEvent?(TimelineIssueEvents @this) => @this.DemilestonedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.DemilestonedIssueEvent? value)
        {
            DemilestonedEvent = value;
        }

        /// <summary>
        /// Renamed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RenamedIssueEvent? RenamedEvent { get; init; }
#else
        public global::G.RenamedIssueEvent? RenamedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RenamedEvent))]
#endif
        public bool IsRenamedEvent => RenamedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.RenamedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RenamedIssueEvent?(TimelineIssueEvents @this) => @this.RenamedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.RenamedIssueEvent? value)
        {
            RenamedEvent = value;
        }

        /// <summary>
        /// Review Requested Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewRequestedIssueEvent? ReviewRequestedEvent { get; init; }
#else
        public global::G.ReviewRequestedIssueEvent? ReviewRequestedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestedEvent))]
#endif
        public bool IsReviewRequestedEvent => ReviewRequestedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.ReviewRequestedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewRequestedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewRequestedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.ReviewRequestedIssueEvent? value)
        {
            ReviewRequestedEvent = value;
        }

        /// <summary>
        /// Review Request Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedEvent { get; init; }
#else
        public global::G.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestRemovedEvent))]
#endif
        public bool IsReviewRequestRemovedEvent => ReviewRequestRemovedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.ReviewRequestRemovedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewRequestRemovedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewRequestRemovedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.ReviewRequestRemovedIssueEvent? value)
        {
            ReviewRequestRemovedEvent = value;
        }

        /// <summary>
        /// Review Dismissed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewDismissedIssueEvent? ReviewDismissedEvent { get; init; }
#else
        public global::G.ReviewDismissedIssueEvent? ReviewDismissedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewDismissedEvent))]
#endif
        public bool IsReviewDismissedEvent => ReviewDismissedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.ReviewDismissedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewDismissedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewDismissedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.ReviewDismissedIssueEvent? value)
        {
            ReviewDismissedEvent = value;
        }

        /// <summary>
        /// Locked Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LockedIssueEvent? LockedEvent { get; init; }
#else
        public global::G.LockedIssueEvent? LockedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LockedEvent))]
#endif
        public bool IsLockedEvent => LockedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.LockedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LockedIssueEvent?(TimelineIssueEvents @this) => @this.LockedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.LockedIssueEvent? value)
        {
            LockedEvent = value;
        }

        /// <summary>
        /// Added to Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AddedToProjectIssueEvent? AddedToProjectEvent { get; init; }
#else
        public global::G.AddedToProjectIssueEvent? AddedToProjectEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddedToProjectEvent))]
#endif
        public bool IsAddedToProjectEvent => AddedToProjectEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.AddedToProjectIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AddedToProjectIssueEvent?(TimelineIssueEvents @this) => @this.AddedToProjectEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.AddedToProjectIssueEvent? value)
        {
            AddedToProjectEvent = value;
        }

        /// <summary>
        /// Moved Column in Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MovedColumnInProjectIssueEvent? MovedColumnInProjectEvent { get; init; }
#else
        public global::G.MovedColumnInProjectIssueEvent? MovedColumnInProjectEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MovedColumnInProjectEvent))]
#endif
        public bool IsMovedColumnInProjectEvent => MovedColumnInProjectEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.MovedColumnInProjectIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MovedColumnInProjectIssueEvent?(TimelineIssueEvents @this) => @this.MovedColumnInProjectEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.MovedColumnInProjectIssueEvent? value)
        {
            MovedColumnInProjectEvent = value;
        }

        /// <summary>
        /// Removed from Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RemovedFromProjectIssueEvent? RemovedFromProjectEvent { get; init; }
#else
        public global::G.RemovedFromProjectIssueEvent? RemovedFromProjectEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemovedFromProjectEvent))]
#endif
        public bool IsRemovedFromProjectEvent => RemovedFromProjectEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.RemovedFromProjectIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RemovedFromProjectIssueEvent?(TimelineIssueEvents @this) => @this.RemovedFromProjectEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.RemovedFromProjectIssueEvent? value)
        {
            RemovedFromProjectEvent = value;
        }

        /// <summary>
        /// Converted Note to Issue Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConvertedNoteToIssueIssueEvent? ConvertedNoteToEvent { get; init; }
#else
        public global::G.ConvertedNoteToIssueIssueEvent? ConvertedNoteToEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConvertedNoteToEvent))]
#endif
        public bool IsConvertedNoteToEvent => ConvertedNoteToEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.ConvertedNoteToIssueIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConvertedNoteToIssueIssueEvent?(TimelineIssueEvents @this) => @this.ConvertedNoteToEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.ConvertedNoteToIssueIssueEvent? value)
        {
            ConvertedNoteToEvent = value;
        }

        /// <summary>
        /// Timeline Comment Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineCommentEvent? CommentEvent { get; init; }
#else
        public global::G.TimelineCommentEvent? CommentEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommentEvent))]
#endif
        public bool IsCommentEvent => CommentEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineCommentEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineCommentEvent?(TimelineIssueEvents @this) => @this.CommentEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineCommentEvent? value)
        {
            CommentEvent = value;
        }

        /// <summary>
        /// Timeline Cross Referenced Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineCrossReferencedEvent? CrossReferencedEvent { get; init; }
#else
        public global::G.TimelineCrossReferencedEvent? CrossReferencedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CrossReferencedEvent))]
#endif
        public bool IsCrossReferencedEvent => CrossReferencedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineCrossReferencedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineCrossReferencedEvent?(TimelineIssueEvents @this) => @this.CrossReferencedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineCrossReferencedEvent? value)
        {
            CrossReferencedEvent = value;
        }

        /// <summary>
        /// Timeline Committed Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineCommittedEvent? CommittedEvent { get; init; }
#else
        public global::G.TimelineCommittedEvent? CommittedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommittedEvent))]
#endif
        public bool IsCommittedEvent => CommittedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineCommittedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineCommittedEvent?(TimelineIssueEvents @this) => @this.CommittedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineCommittedEvent? value)
        {
            CommittedEvent = value;
        }

        /// <summary>
        /// Timeline Reviewed Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineReviewedEvent? ReviewedEvent { get; init; }
#else
        public global::G.TimelineReviewedEvent? ReviewedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewedEvent))]
#endif
        public bool IsReviewedEvent => ReviewedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineReviewedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineReviewedEvent?(TimelineIssueEvents @this) => @this.ReviewedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineReviewedEvent? value)
        {
            ReviewedEvent = value;
        }

        /// <summary>
        /// Timeline Line Commented Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineLineCommentedEvent? LineCommentedEvent { get; init; }
#else
        public global::G.TimelineLineCommentedEvent? LineCommentedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LineCommentedEvent))]
#endif
        public bool IsLineCommentedEvent => LineCommentedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineLineCommentedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineLineCommentedEvent?(TimelineIssueEvents @this) => @this.LineCommentedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineLineCommentedEvent? value)
        {
            LineCommentedEvent = value;
        }

        /// <summary>
        /// Timeline Commit Commented Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineCommitCommentedEvent? CommitCommentedEvent { get; init; }
#else
        public global::G.TimelineCommitCommentedEvent? CommitCommentedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitCommentedEvent))]
#endif
        public bool IsCommitCommentedEvent => CommitCommentedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineCommitCommentedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineCommitCommentedEvent?(TimelineIssueEvents @this) => @this.CommitCommentedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineCommitCommentedEvent? value)
        {
            CommitCommentedEvent = value;
        }

        /// <summary>
        /// Timeline Assigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineAssignedIssueEvent? AssignedEvent { get; init; }
#else
        public global::G.TimelineAssignedIssueEvent? AssignedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssignedEvent))]
#endif
        public bool IsAssignedEvent => AssignedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineAssignedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineAssignedIssueEvent?(TimelineIssueEvents @this) => @this.AssignedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineAssignedIssueEvent? value)
        {
            AssignedEvent = value;
        }

        /// <summary>
        /// Timeline Unassigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineUnassignedIssueEvent? UnassignedEvent { get; init; }
#else
        public global::G.TimelineUnassignedIssueEvent? UnassignedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnassignedEvent))]
#endif
        public bool IsUnassignedEvent => UnassignedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineUnassignedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineUnassignedIssueEvent?(TimelineIssueEvents @this) => @this.UnassignedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineUnassignedIssueEvent? value)
        {
            UnassignedEvent = value;
        }

        /// <summary>
        /// State Change Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StateChangeIssueEvent? StateChangeEvent { get; init; }
#else
        public global::G.StateChangeIssueEvent? StateChangeEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StateChangeEvent))]
#endif
        public bool IsStateChangeEvent => StateChangeEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.StateChangeIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StateChangeIssueEvent?(TimelineIssueEvents @this) => @this.StateChangeEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.StateChangeIssueEvent? value)
        {
            StateChangeEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(
            global::G.LabeledIssueEvent? labeledEvent,
            global::G.UnlabeledIssueEvent? unlabeledEvent,
            global::G.MilestonedIssueEvent? milestonedEvent,
            global::G.DemilestonedIssueEvent? demilestonedEvent,
            global::G.RenamedIssueEvent? renamedEvent,
            global::G.ReviewRequestedIssueEvent? reviewRequestedEvent,
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemovedEvent,
            global::G.ReviewDismissedIssueEvent? reviewDismissedEvent,
            global::G.LockedIssueEvent? lockedEvent,
            global::G.AddedToProjectIssueEvent? addedToProjectEvent,
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProjectEvent,
            global::G.RemovedFromProjectIssueEvent? removedFromProjectEvent,
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteToEvent,
            global::G.TimelineCommentEvent? commentEvent,
            global::G.TimelineCrossReferencedEvent? crossReferencedEvent,
            global::G.TimelineCommittedEvent? committedEvent,
            global::G.TimelineReviewedEvent? reviewedEvent,
            global::G.TimelineLineCommentedEvent? lineCommentedEvent,
            global::G.TimelineCommitCommentedEvent? commitCommentedEvent,
            global::G.TimelineAssignedIssueEvent? assignedEvent,
            global::G.TimelineUnassignedIssueEvent? unassignedEvent,
            global::G.StateChangeIssueEvent? stateChangeEvent
            )
        {
            LabeledEvent = labeledEvent;
            UnlabeledEvent = unlabeledEvent;
            MilestonedEvent = milestonedEvent;
            DemilestonedEvent = demilestonedEvent;
            RenamedEvent = renamedEvent;
            ReviewRequestedEvent = reviewRequestedEvent;
            ReviewRequestRemovedEvent = reviewRequestRemovedEvent;
            ReviewDismissedEvent = reviewDismissedEvent;
            LockedEvent = lockedEvent;
            AddedToProjectEvent = addedToProjectEvent;
            MovedColumnInProjectEvent = movedColumnInProjectEvent;
            RemovedFromProjectEvent = removedFromProjectEvent;
            ConvertedNoteToEvent = convertedNoteToEvent;
            CommentEvent = commentEvent;
            CrossReferencedEvent = crossReferencedEvent;
            CommittedEvent = committedEvent;
            ReviewedEvent = reviewedEvent;
            LineCommentedEvent = lineCommentedEvent;
            CommitCommentedEvent = commitCommentedEvent;
            AssignedEvent = assignedEvent;
            UnassignedEvent = unassignedEvent;
            StateChangeEvent = stateChangeEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StateChangeEvent as object ??
            UnassignedEvent as object ??
            AssignedEvent as object ??
            CommitCommentedEvent as object ??
            LineCommentedEvent as object ??
            ReviewedEvent as object ??
            CommittedEvent as object ??
            CrossReferencedEvent as object ??
            CommentEvent as object ??
            ConvertedNoteToEvent as object ??
            RemovedFromProjectEvent as object ??
            MovedColumnInProjectEvent as object ??
            AddedToProjectEvent as object ??
            LockedEvent as object ??
            ReviewDismissedEvent as object ??
            ReviewRequestRemovedEvent as object ??
            ReviewRequestedEvent as object ??
            RenamedEvent as object ??
            DemilestonedEvent as object ??
            MilestonedEvent as object ??
            UnlabeledEvent as object ??
            LabeledEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLabeledEvent || IsUnlabeledEvent || IsMilestonedEvent || IsDemilestonedEvent || IsRenamedEvent || IsReviewRequestedEvent || IsReviewRequestRemovedEvent || IsReviewDismissedEvent || IsLockedEvent || IsAddedToProjectEvent || IsMovedColumnInProjectEvent || IsRemovedFromProjectEvent || IsConvertedNoteToEvent || IsCommentEvent || IsCrossReferencedEvent || IsCommittedEvent || IsReviewedEvent || IsLineCommentedEvent || IsCommitCommentedEvent || IsAssignedEvent || IsUnassignedEvent || IsStateChangeEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LabeledIssueEvent?, TResult>? labeledEvent = null,
            global::System.Func<global::G.UnlabeledIssueEvent?, TResult>? unlabeledEvent = null,
            global::System.Func<global::G.MilestonedIssueEvent?, TResult>? milestonedEvent = null,
            global::System.Func<global::G.DemilestonedIssueEvent?, TResult>? demilestonedEvent = null,
            global::System.Func<global::G.RenamedIssueEvent?, TResult>? renamedEvent = null,
            global::System.Func<global::G.ReviewRequestedIssueEvent?, TResult>? reviewRequestedEvent = null,
            global::System.Func<global::G.ReviewRequestRemovedIssueEvent?, TResult>? reviewRequestRemovedEvent = null,
            global::System.Func<global::G.ReviewDismissedIssueEvent?, TResult>? reviewDismissedEvent = null,
            global::System.Func<global::G.LockedIssueEvent?, TResult>? lockedEvent = null,
            global::System.Func<global::G.AddedToProjectIssueEvent?, TResult>? addedToProjectEvent = null,
            global::System.Func<global::G.MovedColumnInProjectIssueEvent?, TResult>? movedColumnInProjectEvent = null,
            global::System.Func<global::G.RemovedFromProjectIssueEvent?, TResult>? removedFromProjectEvent = null,
            global::System.Func<global::G.ConvertedNoteToIssueIssueEvent?, TResult>? convertedNoteToEvent = null,
            global::System.Func<global::G.TimelineCommentEvent?, TResult>? commentEvent = null,
            global::System.Func<global::G.TimelineCrossReferencedEvent?, TResult>? crossReferencedEvent = null,
            global::System.Func<global::G.TimelineCommittedEvent?, TResult>? committedEvent = null,
            global::System.Func<global::G.TimelineReviewedEvent?, TResult>? reviewedEvent = null,
            global::System.Func<global::G.TimelineLineCommentedEvent?, TResult>? lineCommentedEvent = null,
            global::System.Func<global::G.TimelineCommitCommentedEvent?, TResult>? commitCommentedEvent = null,
            global::System.Func<global::G.TimelineAssignedIssueEvent?, TResult>? assignedEvent = null,
            global::System.Func<global::G.TimelineUnassignedIssueEvent?, TResult>? unassignedEvent = null,
            global::System.Func<global::G.StateChangeIssueEvent?, TResult>? stateChangeEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledEvent && labeledEvent != null)
            {
                return labeledEvent(LabeledEvent!);
            }
            else if (IsUnlabeledEvent && unlabeledEvent != null)
            {
                return unlabeledEvent(UnlabeledEvent!);
            }
            else if (IsMilestonedEvent && milestonedEvent != null)
            {
                return milestonedEvent(MilestonedEvent!);
            }
            else if (IsDemilestonedEvent && demilestonedEvent != null)
            {
                return demilestonedEvent(DemilestonedEvent!);
            }
            else if (IsRenamedEvent && renamedEvent != null)
            {
                return renamedEvent(RenamedEvent!);
            }
            else if (IsReviewRequestedEvent && reviewRequestedEvent != null)
            {
                return reviewRequestedEvent(ReviewRequestedEvent!);
            }
            else if (IsReviewRequestRemovedEvent && reviewRequestRemovedEvent != null)
            {
                return reviewRequestRemovedEvent(ReviewRequestRemovedEvent!);
            }
            else if (IsReviewDismissedEvent && reviewDismissedEvent != null)
            {
                return reviewDismissedEvent(ReviewDismissedEvent!);
            }
            else if (IsLockedEvent && lockedEvent != null)
            {
                return lockedEvent(LockedEvent!);
            }
            else if (IsAddedToProjectEvent && addedToProjectEvent != null)
            {
                return addedToProjectEvent(AddedToProjectEvent!);
            }
            else if (IsMovedColumnInProjectEvent && movedColumnInProjectEvent != null)
            {
                return movedColumnInProjectEvent(MovedColumnInProjectEvent!);
            }
            else if (IsRemovedFromProjectEvent && removedFromProjectEvent != null)
            {
                return removedFromProjectEvent(RemovedFromProjectEvent!);
            }
            else if (IsConvertedNoteToEvent && convertedNoteToEvent != null)
            {
                return convertedNoteToEvent(ConvertedNoteToEvent!);
            }
            else if (IsCommentEvent && commentEvent != null)
            {
                return commentEvent(CommentEvent!);
            }
            else if (IsCrossReferencedEvent && crossReferencedEvent != null)
            {
                return crossReferencedEvent(CrossReferencedEvent!);
            }
            else if (IsCommittedEvent && committedEvent != null)
            {
                return committedEvent(CommittedEvent!);
            }
            else if (IsReviewedEvent && reviewedEvent != null)
            {
                return reviewedEvent(ReviewedEvent!);
            }
            else if (IsLineCommentedEvent && lineCommentedEvent != null)
            {
                return lineCommentedEvent(LineCommentedEvent!);
            }
            else if (IsCommitCommentedEvent && commitCommentedEvent != null)
            {
                return commitCommentedEvent(CommitCommentedEvent!);
            }
            else if (IsAssignedEvent && assignedEvent != null)
            {
                return assignedEvent(AssignedEvent!);
            }
            else if (IsUnassignedEvent && unassignedEvent != null)
            {
                return unassignedEvent(UnassignedEvent!);
            }
            else if (IsStateChangeEvent && stateChangeEvent != null)
            {
                return stateChangeEvent(StateChangeEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LabeledIssueEvent?>? labeledEvent = null,
            global::System.Action<global::G.UnlabeledIssueEvent?>? unlabeledEvent = null,
            global::System.Action<global::G.MilestonedIssueEvent?>? milestonedEvent = null,
            global::System.Action<global::G.DemilestonedIssueEvent?>? demilestonedEvent = null,
            global::System.Action<global::G.RenamedIssueEvent?>? renamedEvent = null,
            global::System.Action<global::G.ReviewRequestedIssueEvent?>? reviewRequestedEvent = null,
            global::System.Action<global::G.ReviewRequestRemovedIssueEvent?>? reviewRequestRemovedEvent = null,
            global::System.Action<global::G.ReviewDismissedIssueEvent?>? reviewDismissedEvent = null,
            global::System.Action<global::G.LockedIssueEvent?>? lockedEvent = null,
            global::System.Action<global::G.AddedToProjectIssueEvent?>? addedToProjectEvent = null,
            global::System.Action<global::G.MovedColumnInProjectIssueEvent?>? movedColumnInProjectEvent = null,
            global::System.Action<global::G.RemovedFromProjectIssueEvent?>? removedFromProjectEvent = null,
            global::System.Action<global::G.ConvertedNoteToIssueIssueEvent?>? convertedNoteToEvent = null,
            global::System.Action<global::G.TimelineCommentEvent?>? commentEvent = null,
            global::System.Action<global::G.TimelineCrossReferencedEvent?>? crossReferencedEvent = null,
            global::System.Action<global::G.TimelineCommittedEvent?>? committedEvent = null,
            global::System.Action<global::G.TimelineReviewedEvent?>? reviewedEvent = null,
            global::System.Action<global::G.TimelineLineCommentedEvent?>? lineCommentedEvent = null,
            global::System.Action<global::G.TimelineCommitCommentedEvent?>? commitCommentedEvent = null,
            global::System.Action<global::G.TimelineAssignedIssueEvent?>? assignedEvent = null,
            global::System.Action<global::G.TimelineUnassignedIssueEvent?>? unassignedEvent = null,
            global::System.Action<global::G.StateChangeIssueEvent?>? stateChangeEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledEvent)
            {
                labeledEvent?.Invoke(LabeledEvent!);
            }
            else if (IsUnlabeledEvent)
            {
                unlabeledEvent?.Invoke(UnlabeledEvent!);
            }
            else if (IsMilestonedEvent)
            {
                milestonedEvent?.Invoke(MilestonedEvent!);
            }
            else if (IsDemilestonedEvent)
            {
                demilestonedEvent?.Invoke(DemilestonedEvent!);
            }
            else if (IsRenamedEvent)
            {
                renamedEvent?.Invoke(RenamedEvent!);
            }
            else if (IsReviewRequestedEvent)
            {
                reviewRequestedEvent?.Invoke(ReviewRequestedEvent!);
            }
            else if (IsReviewRequestRemovedEvent)
            {
                reviewRequestRemovedEvent?.Invoke(ReviewRequestRemovedEvent!);
            }
            else if (IsReviewDismissedEvent)
            {
                reviewDismissedEvent?.Invoke(ReviewDismissedEvent!);
            }
            else if (IsLockedEvent)
            {
                lockedEvent?.Invoke(LockedEvent!);
            }
            else if (IsAddedToProjectEvent)
            {
                addedToProjectEvent?.Invoke(AddedToProjectEvent!);
            }
            else if (IsMovedColumnInProjectEvent)
            {
                movedColumnInProjectEvent?.Invoke(MovedColumnInProjectEvent!);
            }
            else if (IsRemovedFromProjectEvent)
            {
                removedFromProjectEvent?.Invoke(RemovedFromProjectEvent!);
            }
            else if (IsConvertedNoteToEvent)
            {
                convertedNoteToEvent?.Invoke(ConvertedNoteToEvent!);
            }
            else if (IsCommentEvent)
            {
                commentEvent?.Invoke(CommentEvent!);
            }
            else if (IsCrossReferencedEvent)
            {
                crossReferencedEvent?.Invoke(CrossReferencedEvent!);
            }
            else if (IsCommittedEvent)
            {
                committedEvent?.Invoke(CommittedEvent!);
            }
            else if (IsReviewedEvent)
            {
                reviewedEvent?.Invoke(ReviewedEvent!);
            }
            else if (IsLineCommentedEvent)
            {
                lineCommentedEvent?.Invoke(LineCommentedEvent!);
            }
            else if (IsCommitCommentedEvent)
            {
                commitCommentedEvent?.Invoke(CommitCommentedEvent!);
            }
            else if (IsAssignedEvent)
            {
                assignedEvent?.Invoke(AssignedEvent!);
            }
            else if (IsUnassignedEvent)
            {
                unassignedEvent?.Invoke(UnassignedEvent!);
            }
            else if (IsStateChangeEvent)
            {
                stateChangeEvent?.Invoke(StateChangeEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LabeledEvent,
                typeof(global::G.LabeledIssueEvent),
                UnlabeledEvent,
                typeof(global::G.UnlabeledIssueEvent),
                MilestonedEvent,
                typeof(global::G.MilestonedIssueEvent),
                DemilestonedEvent,
                typeof(global::G.DemilestonedIssueEvent),
                RenamedEvent,
                typeof(global::G.RenamedIssueEvent),
                ReviewRequestedEvent,
                typeof(global::G.ReviewRequestedIssueEvent),
                ReviewRequestRemovedEvent,
                typeof(global::G.ReviewRequestRemovedIssueEvent),
                ReviewDismissedEvent,
                typeof(global::G.ReviewDismissedIssueEvent),
                LockedEvent,
                typeof(global::G.LockedIssueEvent),
                AddedToProjectEvent,
                typeof(global::G.AddedToProjectIssueEvent),
                MovedColumnInProjectEvent,
                typeof(global::G.MovedColumnInProjectIssueEvent),
                RemovedFromProjectEvent,
                typeof(global::G.RemovedFromProjectIssueEvent),
                ConvertedNoteToEvent,
                typeof(global::G.ConvertedNoteToIssueIssueEvent),
                CommentEvent,
                typeof(global::G.TimelineCommentEvent),
                CrossReferencedEvent,
                typeof(global::G.TimelineCrossReferencedEvent),
                CommittedEvent,
                typeof(global::G.TimelineCommittedEvent),
                ReviewedEvent,
                typeof(global::G.TimelineReviewedEvent),
                LineCommentedEvent,
                typeof(global::G.TimelineLineCommentedEvent),
                CommitCommentedEvent,
                typeof(global::G.TimelineCommitCommentedEvent),
                AssignedEvent,
                typeof(global::G.TimelineAssignedIssueEvent),
                UnassignedEvent,
                typeof(global::G.TimelineUnassignedIssueEvent),
                StateChangeEvent,
                typeof(global::G.StateChangeIssueEvent),
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
        public bool Equals(TimelineIssueEvents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LabeledIssueEvent?>.Default.Equals(LabeledEvent, other.LabeledEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UnlabeledIssueEvent?>.Default.Equals(UnlabeledEvent, other.UnlabeledEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MilestonedIssueEvent?>.Default.Equals(MilestonedEvent, other.MilestonedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DemilestonedIssueEvent?>.Default.Equals(DemilestonedEvent, other.DemilestonedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RenamedIssueEvent?>.Default.Equals(RenamedEvent, other.RenamedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewRequestedIssueEvent?>.Default.Equals(ReviewRequestedEvent, other.ReviewRequestedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewRequestRemovedIssueEvent?>.Default.Equals(ReviewRequestRemovedEvent, other.ReviewRequestRemovedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewDismissedIssueEvent?>.Default.Equals(ReviewDismissedEvent, other.ReviewDismissedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LockedIssueEvent?>.Default.Equals(LockedEvent, other.LockedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AddedToProjectIssueEvent?>.Default.Equals(AddedToProjectEvent, other.AddedToProjectEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MovedColumnInProjectIssueEvent?>.Default.Equals(MovedColumnInProjectEvent, other.MovedColumnInProjectEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RemovedFromProjectIssueEvent?>.Default.Equals(RemovedFromProjectEvent, other.RemovedFromProjectEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConvertedNoteToIssueIssueEvent?>.Default.Equals(ConvertedNoteToEvent, other.ConvertedNoteToEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineCommentEvent?>.Default.Equals(CommentEvent, other.CommentEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineCrossReferencedEvent?>.Default.Equals(CrossReferencedEvent, other.CrossReferencedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineCommittedEvent?>.Default.Equals(CommittedEvent, other.CommittedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineReviewedEvent?>.Default.Equals(ReviewedEvent, other.ReviewedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineLineCommentedEvent?>.Default.Equals(LineCommentedEvent, other.LineCommentedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineCommitCommentedEvent?>.Default.Equals(CommitCommentedEvent, other.CommitCommentedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineAssignedIssueEvent?>.Default.Equals(AssignedEvent, other.AssignedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineUnassignedIssueEvent?>.Default.Equals(UnassignedEvent, other.UnassignedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StateChangeIssueEvent?>.Default.Equals(StateChangeEvent, other.StateChangeEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TimelineIssueEvents obj1, TimelineIssueEvents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TimelineIssueEvents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TimelineIssueEvents obj1, TimelineIssueEvents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TimelineIssueEvents o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.TimelineIssueEvents? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TimelineIssueEvents>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.TimelineIssueEvents?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.TimelineIssueEvents?>(serializer.Deserialize<global::G.TimelineIssueEvents>(jsonReader));
        }

    }
}
