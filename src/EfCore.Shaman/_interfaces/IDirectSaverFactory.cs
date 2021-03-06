﻿using System;

namespace EfCore.Shaman
{
    public interface IDirectSaverFactory : IShamanService
    {
        #region Instance Methods

        IDirectSaver<T> GetDirectSaver<T>(Type contextType, Func<ShamanOptions> optionsFactory = null);

        #endregion
    }
}