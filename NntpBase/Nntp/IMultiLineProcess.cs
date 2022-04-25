namespace NntpBase.Nntp {
    public interface IMultiLineProcess {
        internal void xStartProcess();
        internal void xProcessLine(string pLine);
        internal void xEndProcess();
    }
}
