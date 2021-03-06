﻿/*
 * Copyright 2019 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesEditorUI : MonoBehaviour
{
  public TMPro.TMP_InputField nameField;
  public UnityEngine.UI.Button closeButton;

  public SliderWrapperUI speedSlider;
  public SliderWrapperUI lifetimeSlider;
  public SliderWrapperUI startSizeSlider;
  public SliderWrapperUI endSizeSlider;
  public SliderWrapperUI gravitySlider;

  public UnityEngine.UI.RawImage previewRawImage;
  public UnityEngine.UI.Toggle burstPreviewToggle;

  public ColorGradientFieldUI colorGradientField;
  public GameObject colorPanelObject;
  public ColorFieldUI colorField;

  public ImageToggleUI sphereEmissionToggle;
  public ImageToggleUI coneEmissionToggle;
  public ImageToggleUI circleEmissionToggle;
  public ImageToggleUI rectangleEmissionToggle;

  public SliderWrapperUI shapeSizeSlider;
  public SliderWrapperUI densitySlider;
}
