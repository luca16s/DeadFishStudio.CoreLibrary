﻿// <copyright file="IUnitOfWork.cs" company="Gian Luca da Silva Figueiredo">
// Copyright (c) Gian Luca da Silva Figueiredo. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace DeadFishStudio.CoreLibrary
{
    using Microsoft.EntityFrameworkCore.Storage;

    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Classe para servir de interface no salvamento do banco de dados.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Salva as modificações no banco.
        /// </summary>
        /// <param name="cancellationToken">Cancela o processo de salvamento.</param>
        /// <returns>Retorna o status da operação.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Salva a entidade modificada.
        /// </summary>
        /// <param name="cancellationToken">Cancela o processo de salvamento da entidade.</param>
        /// <returns>Retorna o sucesso da operação.</returns>
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Inicia transação com o banco de dados.
        /// </summary>
        /// <returns>Retorna a transação.</returns>
        Task<IDbContextTransaction?> BeginTransactionAsync();

        /// <summary>
        /// Comita a transação do banco.
        /// </summary>
        /// <param name="transaction">Transação aberta.</param>
        /// <returns>Retorna a task.</returns>
        Task CommitTransactionAsync(IDbContextTransaction transaction);

        /// <summary>
        /// Reverte alterações.
        /// </summary>
        void RollbackTransaction();
    }
}