﻿// Decompiled with JetBrains decompiler
// Type: ReAuth.ConcurrentQueueExtensions
// Assembly: ReAuth, Version=1.0.6953.41762, Culture=neutral, PublicKeyToken=null
// MVID: 30CD6CC8-2A35-4496-A933-8D554CB42274
// Assembly location: C:\Users\shawtware\Desktop\ReAuth.exe

using System.Collections.Concurrent;

namespace ReAuth
{
  internal static class ConcurrentQueueExtensions
  {
    public static void Clear<T>(this ConcurrentQueue<T> queue)
    {
      T result;
      do
        ;
      while (queue.TryDequeue(out result));
    }
  }
}
