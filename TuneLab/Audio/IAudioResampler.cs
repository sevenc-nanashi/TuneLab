﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneLab.Audio;

internal interface IAudioResampler
{
    IAudioStream Resample(IAudioProvider input, int outputSamplingRate);
}
