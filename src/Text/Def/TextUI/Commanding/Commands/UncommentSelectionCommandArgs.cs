namespace Microsoft.VisualStudio.Text.Editor.Commanding.Commands
{
    public sealed class UncommentSelectionCommandArgs : EditorCommandArgs
    {
        public UncommentSelectionCommandArgs(ITextView textView, ITextBuffer subjectBuffer) : base(textView, subjectBuffer)
        {
        }
    }
}
