namespace SharpArchTemplate.Tasks.Contracts
{
    #region Using Directives

    using System.Collections.Generic;

    using SharpArchTemplate.Domain;

    #endregion

    public interface ICategoryQueryTasks
    {
        IList<Category> GetAll();

        Category Get(int categoryId);
    }
}
