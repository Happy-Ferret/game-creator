﻿using App.Contracts;

namespace GameCreator.Contracts.Services
{
    /// <summary>
    /// Interface for representing a project.
    /// </summary>
    public interface IProject
    {
        /// <summary>
        /// Gets or sets the repository for this project's resources.
        /// </summary>
        IAppRepository Repository { get; set; }
    }
}
