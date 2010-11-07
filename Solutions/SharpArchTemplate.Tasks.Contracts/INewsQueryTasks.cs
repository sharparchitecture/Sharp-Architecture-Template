namespace SharpArchTemplate.Tasks.Contracts
{
    #region Using Directives

    using System.Collections.Generic;

    using SharpArchTemplate.Domain;

    #endregion

    public interface INewsQueryTasks
    {
        IList<NewsItem> GetProjectBuzz();

        IList<NewsItem> GetDevelopmentTeamBuzz();
    }
}