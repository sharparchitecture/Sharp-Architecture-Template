namespace SharpArchTemplate.Tasks.Contracts
{
    #region Using Directives

    using System.Collections.Generic;

    using SharpArchTemplate.Domain;

    #endregion

    public interface IAssertionQueryTasks
    {
        IList<Assertion> ByTag(string tagName);
    }
}
