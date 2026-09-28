//HintName: G.Models.ComputerAction.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ComputerAction : global::System.IEquatable<ComputerAction>
    {
        /// <summary>
        /// A click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Click? Click { get; init; }
#else
        public global::G.Click? Click { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Click))]
#endif
        public bool IsClick => Click != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Click? value)
        {
            value = Click;
            return IsClick;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Click PickClick() => Click is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Click' but the value was {ToString()}.");

        /// <summary>
        /// A double click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DoubleClick? DoubleClick { get; init; }
#else
        public global::G.DoubleClick? DoubleClick { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DoubleClick))]
#endif
        public bool IsDoubleClick => DoubleClick != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDoubleClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.DoubleClick? value)
        {
            value = DoubleClick;
            return IsDoubleClick;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.DoubleClick PickDoubleClick() => DoubleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleClick' but the value was {ToString()}.");

        /// <summary>
        /// A drag action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Drag? Drag { get; init; }
#else
        public global::G.Drag? Drag { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Drag))]
#endif
        public bool IsDrag => Drag != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDrag(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Drag? value)
        {
            value = Drag;
            return IsDrag;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Drag PickDrag() => Drag is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Drag' but the value was {ToString()}.");

        /// <summary>
        /// A collection of keypresses the model would like to perform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyPress? KeyPress { get; init; }
#else
        public global::G.KeyPress? KeyPress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyPress))]
#endif
        public bool IsKeyPress => KeyPress != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKeyPress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.KeyPress? value)
        {
            value = KeyPress;
            return IsKeyPress;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.KeyPress PickKeyPress() => KeyPress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KeyPress' but the value was {ToString()}.");

        /// <summary>
        /// A mouse move action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Move? Move { get; init; }
#else
        public global::G.Move? Move { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Move))]
#endif
        public bool IsMove => Move != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMove(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Move? value)
        {
            value = Move;
            return IsMove;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Move PickMove() => Move is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Move' but the value was {ToString()}.");

        /// <summary>
        /// A screenshot action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Screenshot? Screenshot { get; init; }
#else
        public global::G.Screenshot? Screenshot { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Screenshot))]
#endif
        public bool IsScreenshot => Screenshot != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScreenshot(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Screenshot? value)
        {
            value = Screenshot;
            return IsScreenshot;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Screenshot PickScreenshot() => Screenshot is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Screenshot' but the value was {ToString()}.");

        /// <summary>
        /// A scroll action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Scroll? Scroll { get; init; }
#else
        public global::G.Scroll? Scroll { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scroll))]
#endif
        public bool IsScroll => Scroll != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScroll(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Scroll? value)
        {
            value = Scroll;
            return IsScroll;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Scroll PickScroll() => Scroll is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scroll' but the value was {ToString()}.");

        /// <summary>
        /// An action to type in text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Type? Type { get; init; }
#else
        public global::G.Type? Type { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Type))]
#endif
        public bool IsType => Type != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickType(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Type? value)
        {
            value = Type;
            return IsType;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Type PickType() => Type is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Type' but the value was {ToString()}.");

        /// <summary>
        /// A wait action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Wait? Wait { get; init; }
#else
        public global::G.Wait? Wait { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wait))]
#endif
        public bool IsWait => Wait != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWait(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Wait? value)
        {
            value = Wait;
            return IsWait;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Wait PickWait() => Wait is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wait' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.Click value) => new ComputerAction((global::G.Click?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Click?(ComputerAction @this) => @this.Click;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.Click? value)
        {
            Click = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromClick(global::G.Click? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.DoubleClick value) => new ComputerAction((global::G.DoubleClick?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DoubleClick?(ComputerAction @this) => @this.DoubleClick;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.DoubleClick? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromDoubleClick(global::G.DoubleClick? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.Drag value) => new ComputerAction((global::G.Drag?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Drag?(ComputerAction @this) => @this.Drag;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.Drag? value)
        {
            Drag = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromDrag(global::G.Drag? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.KeyPress value) => new ComputerAction((global::G.KeyPress?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyPress?(ComputerAction @this) => @this.KeyPress;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.KeyPress? value)
        {
            KeyPress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromKeyPress(global::G.KeyPress? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.Move value) => new ComputerAction((global::G.Move?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Move?(ComputerAction @this) => @this.Move;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.Move? value)
        {
            Move = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromMove(global::G.Move? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.Screenshot value) => new ComputerAction((global::G.Screenshot?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Screenshot?(ComputerAction @this) => @this.Screenshot;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.Screenshot? value)
        {
            Screenshot = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromScreenshot(global::G.Screenshot? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.Scroll value) => new ComputerAction((global::G.Scroll?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Scroll?(ComputerAction @this) => @this.Scroll;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.Scroll? value)
        {
            Scroll = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromScroll(global::G.Scroll? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.Type value) => new ComputerAction((global::G.Type?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Type?(ComputerAction @this) => @this.Type;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.Type? value)
        {
            Type = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromType(global::G.Type? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::G.Wait value) => new ComputerAction((global::G.Wait?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Wait?(ComputerAction @this) => @this.Wait;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::G.Wait? value)
        {
            Wait = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromWait(global::G.Wait? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(
            global::G.Click? click,
            global::G.DoubleClick? doubleClick,
            global::G.Drag? drag,
            global::G.KeyPress? keyPress,
            global::G.Move? move,
            global::G.Screenshot? screenshot,
            global::G.Scroll? scroll,
            global::G.Type? type,
            global::G.Wait? wait
            )
        {
            Click = click;
            DoubleClick = doubleClick;
            Drag = drag;
            KeyPress = keyPress;
            Move = move;
            Screenshot = screenshot;
            Scroll = scroll;
            Type = type;
            Wait = wait;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Wait as object ??
            Type as object ??
            Scroll as object ??
            Screenshot as object ??
            Move as object ??
            KeyPress as object ??
            Drag as object ??
            DoubleClick as object ??
            Click as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Click?.ToString() ??
            DoubleClick?.ToString() ??
            Drag?.ToString() ??
            KeyPress?.ToString() ??
            Move?.ToString() ??
            Screenshot?.ToString() ??
            Scroll?.ToString() ??
            Type?.ToString() ??
            Wait?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && IsWait;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Click, TResult>? click = null,
            global::System.Func<global::G.DoubleClick, TResult>? doubleClick = null,
            global::System.Func<global::G.Drag, TResult>? drag = null,
            global::System.Func<global::G.KeyPress, TResult>? keyPress = null,
            global::System.Func<global::G.Move, TResult>? move = null,
            global::System.Func<global::G.Screenshot, TResult>? screenshot = null,
            global::System.Func<global::G.Scroll, TResult>? scroll = null,
            global::System.Func<global::G.Type, TResult>? type = null,
            global::System.Func<global::G.Wait, TResult>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Click is { } __value0 && click != null)
            {
                return click(__value0);
            }
            else if (DoubleClick is { } __value1 && doubleClick != null)
            {
                return doubleClick(__value1);
            }
            else if (Drag is { } __value2 && drag != null)
            {
                return drag(__value2);
            }
            else if (KeyPress is { } __value3 && keyPress != null)
            {
                return keyPress(__value3);
            }
            else if (Move is { } __value4 && move != null)
            {
                return move(__value4);
            }
            else if (Screenshot is { } __value5 && screenshot != null)
            {
                return screenshot(__value5);
            }
            else if (Scroll is { } __value6 && scroll != null)
            {
                return scroll(__value6);
            }
            else if (Type is { } __value7 && type != null)
            {
                return type(__value7);
            }
            else if (Wait is { } __value8 && wait != null)
            {
                return wait(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Click>? click = null,

            global::System.Action<global::G.DoubleClick>? doubleClick = null,

            global::System.Action<global::G.Drag>? drag = null,

            global::System.Action<global::G.KeyPress>? keyPress = null,

            global::System.Action<global::G.Move>? move = null,

            global::System.Action<global::G.Screenshot>? screenshot = null,

            global::System.Action<global::G.Scroll>? scroll = null,

            global::System.Action<global::G.Type>? type = null,

            global::System.Action<global::G.Wait>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Click is { } __value0)
            {
                click?.Invoke(__value0);
            }
            else if (DoubleClick is { } __value1)
            {
                doubleClick?.Invoke(__value1);
            }
            else if (Drag is { } __value2)
            {
                drag?.Invoke(__value2);
            }
            else if (KeyPress is { } __value3)
            {
                keyPress?.Invoke(__value3);
            }
            else if (Move is { } __value4)
            {
                move?.Invoke(__value4);
            }
            else if (Screenshot is { } __value5)
            {
                screenshot?.Invoke(__value5);
            }
            else if (Scroll is { } __value6)
            {
                scroll?.Invoke(__value6);
            }
            else if (Type is { } __value7)
            {
                type?.Invoke(__value7);
            }
            else if (Wait is { } __value8)
            {
                wait?.Invoke(__value8);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.Click>? click = null,
            global::System.Action<global::G.DoubleClick>? doubleClick = null,
            global::System.Action<global::G.Drag>? drag = null,
            global::System.Action<global::G.KeyPress>? keyPress = null,
            global::System.Action<global::G.Move>? move = null,
            global::System.Action<global::G.Screenshot>? screenshot = null,
            global::System.Action<global::G.Scroll>? scroll = null,
            global::System.Action<global::G.Type>? type = null,
            global::System.Action<global::G.Wait>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Click is { } __value0)
            {
                click?.Invoke(__value0);
            }
            else if (DoubleClick is { } __value1)
            {
                doubleClick?.Invoke(__value1);
            }
            else if (Drag is { } __value2)
            {
                drag?.Invoke(__value2);
            }
            else if (KeyPress is { } __value3)
            {
                keyPress?.Invoke(__value3);
            }
            else if (Move is { } __value4)
            {
                move?.Invoke(__value4);
            }
            else if (Screenshot is { } __value5)
            {
                screenshot?.Invoke(__value5);
            }
            else if (Scroll is { } __value6)
            {
                scroll?.Invoke(__value6);
            }
            else if (Type is { } __value7)
            {
                type?.Invoke(__value7);
            }
            else if (Wait is { } __value8)
            {
                wait?.Invoke(__value8);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Click,
                typeof(global::G.Click),
                DoubleClick,
                typeof(global::G.DoubleClick),
                Drag,
                typeof(global::G.Drag),
                KeyPress,
                typeof(global::G.KeyPress),
                Move,
                typeof(global::G.Move),
                Screenshot,
                typeof(global::G.Screenshot),
                Scroll,
                typeof(global::G.Scroll),
                Type,
                typeof(global::G.Type),
                Wait,
                typeof(global::G.Wait),
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
        public bool Equals(ComputerAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Click?>.Default.Equals(Click, other.Click) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DoubleClick?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Drag?>.Default.Equals(Drag, other.Drag) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyPress?>.Default.Equals(KeyPress, other.KeyPress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Move?>.Default.Equals(Move, other.Move) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Screenshot?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Scroll?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Type?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Wait?>.Default.Equals(Wait, other.Wait) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ComputerAction obj1, ComputerAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ComputerAction obj1, ComputerAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerAction o && Equals(o);
        }
    }
}
