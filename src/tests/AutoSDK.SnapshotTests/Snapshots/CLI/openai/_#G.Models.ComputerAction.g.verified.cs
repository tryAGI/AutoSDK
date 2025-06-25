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
            global::System.Func<global::G.Click?, TResult>? click = null,
            global::System.Func<global::G.DoubleClick?, TResult>? doubleClick = null,
            global::System.Func<global::G.Drag?, TResult>? drag = null,
            global::System.Func<global::G.KeyPress?, TResult>? keyPress = null,
            global::System.Func<global::G.Move?, TResult>? move = null,
            global::System.Func<global::G.Screenshot?, TResult>? screenshot = null,
            global::System.Func<global::G.Scroll?, TResult>? scroll = null,
            global::System.Func<global::G.Type?, TResult>? type = null,
            global::System.Func<global::G.Wait?, TResult>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClick && click != null)
            {
                return click(Click!);
            }
            else if (IsDoubleClick && doubleClick != null)
            {
                return doubleClick(DoubleClick!);
            }
            else if (IsDrag && drag != null)
            {
                return drag(Drag!);
            }
            else if (IsKeyPress && keyPress != null)
            {
                return keyPress(KeyPress!);
            }
            else if (IsMove && move != null)
            {
                return move(Move!);
            }
            else if (IsScreenshot && screenshot != null)
            {
                return screenshot(Screenshot!);
            }
            else if (IsScroll && scroll != null)
            {
                return scroll(Scroll!);
            }
            else if (IsType && type != null)
            {
                return type(Type!);
            }
            else if (IsWait && wait != null)
            {
                return wait(Wait!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Click?>? click = null,
            global::System.Action<global::G.DoubleClick?>? doubleClick = null,
            global::System.Action<global::G.Drag?>? drag = null,
            global::System.Action<global::G.KeyPress?>? keyPress = null,
            global::System.Action<global::G.Move?>? move = null,
            global::System.Action<global::G.Screenshot?>? screenshot = null,
            global::System.Action<global::G.Scroll?>? scroll = null,
            global::System.Action<global::G.Type?>? type = null,
            global::System.Action<global::G.Wait?>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClick)
            {
                click?.Invoke(Click!);
            }
            else if (IsDoubleClick)
            {
                doubleClick?.Invoke(DoubleClick!);
            }
            else if (IsDrag)
            {
                drag?.Invoke(Drag!);
            }
            else if (IsKeyPress)
            {
                keyPress?.Invoke(KeyPress!);
            }
            else if (IsMove)
            {
                move?.Invoke(Move!);
            }
            else if (IsScreenshot)
            {
                screenshot?.Invoke(Screenshot!);
            }
            else if (IsScroll)
            {
                scroll?.Invoke(Scroll!);
            }
            else if (IsType)
            {
                type?.Invoke(Type!);
            }
            else if (IsWait)
            {
                wait?.Invoke(Wait!);
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
