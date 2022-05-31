﻿using System.Collections.ObjectModel;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Media;

namespace Avalonia.Controls
{
    public partial class ColorView
    {
        // SelectedTab

        /// <summary>
        /// Defines the <see cref="Color"/> property.
        /// </summary>
        public static readonly StyledProperty<Color> ColorProperty =
            AvaloniaProperty.Register<ColorView, Color>(
                nameof(Color),
                Colors.White,
                defaultBindingMode: BindingMode.TwoWay);

        /// <summary>
        /// Defines the <see cref="ColorModel"/> property.
        /// </summary>
        public static readonly StyledProperty<ColorModel> ColorModelProperty =
            AvaloniaProperty.Register<ColorView, ColorModel>(
                nameof(ColorModel),
                ColorModel.Rgba);

        /// <summary>
        /// Defines the <see cref="ColorSpectrumComponents"/> property.
        /// </summary>
        public static readonly StyledProperty<ColorSpectrumComponents> ColorSpectrumComponentsProperty =
            AvaloniaProperty.Register<ColorView, ColorSpectrumComponents>(
                nameof(ColorSpectrumComponents),
                ColorSpectrumComponents.HueSaturation);

        /// <summary>
        /// Defines the <see cref="ColorSpectrumShape"/> property.
        /// </summary>
        public static readonly StyledProperty<ColorSpectrumShape> ColorSpectrumShapeProperty =
            AvaloniaProperty.Register<ColorView, ColorSpectrumShape>(
                nameof(ColorSpectrumShape),
                ColorSpectrumShape.Box);

        /// <summary>
        /// Defines the <see cref="CustomPaletteColors"/> property.
        /// </summary>
        public static readonly DirectProperty<ColorView, ObservableCollection<Color>> CustomPaletteColorsProperty =
            AvaloniaProperty.RegisterDirect<ColorView, ObservableCollection<Color>>(
                nameof(CustomPaletteColors),
                o => o.CustomPaletteColors);

        /// <summary>
        /// Defines the <see cref="CustomPaletteColumnCount"/> property.
        /// </summary>
        public static readonly StyledProperty<int> CustomPaletteColumnCountProperty =
            AvaloniaProperty.Register<ColorView, int>(
                nameof(CustomPaletteColumnCount),
                4);

        /// <summary>
        /// Defines the <see cref="CustomPalette"/> property.
        /// </summary>
        public static readonly StyledProperty<IColorPalette?> CustomPaletteProperty =
            AvaloniaProperty.Register<ColorView, IColorPalette?>(
                nameof(CustomPalette),
                null);

        /// <summary>
        /// Defines the <see cref="HsvColor"/> property.
        /// </summary>
        public static readonly StyledProperty<HsvColor> HsvColorProperty =
            AvaloniaProperty.Register<ColorView, HsvColor>(
                nameof(HsvColor),
                Colors.White.ToHsv(),
                defaultBindingMode: BindingMode.TwoWay);

        /// <summary>
        /// Defines the <see cref="IsAlphaEnabled"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsAlphaEnabledProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(IsAlphaEnabled),
                false);

        /// <summary>
        /// Defines the <see cref="IsAlphaVisible"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsAlphaVisibleProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(IsAlphaVisible),
                true);

        /// <summary>
        /// Defines the <see cref="IsColorPaletteVisible"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsColorPaletteVisibleProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(IsColorPaletteVisible),
                true);

        /// <summary>
        /// Defines the <see cref="IsColorPreviewVisible"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsColorPreviewVisibleProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(IsColorPreviewVisible),
                true);

        /// <summary>
        /// Defines the <see cref="IsColorSliderVisible"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsColorSliderVisibleProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(IsColorSliderVisible),
                true);

        /// <summary>
        /// Defines the <see cref="IsColorSpectrumVisible"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsColorSpectrumVisibleProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(IsColorSpectrumVisible),
                true);

        /// <summary>
        /// Defines the <see cref="IsComponentTextInputVisible"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsComponentTextInputVisibleProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(IsComponentTextInputVisible),
                true);

        /// <summary>
        /// Defines the <see cref="IsHexInputVisible"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsHexInputVisibleProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(IsHexInputVisible),
                true);

        /// <summary>
        /// Defines the <see cref="MaxHue"/> property.
        /// </summary>
        public static readonly StyledProperty<int> MaxHueProperty =
            AvaloniaProperty.Register<ColorView, int>(
                nameof(MaxHue),
                359);

        /// <summary>
        /// Defines the <see cref="MaxSaturation"/> property.
        /// </summary>
        public static readonly StyledProperty<int> MaxSaturationProperty =
            AvaloniaProperty.Register<ColorView, int>(
                nameof(MaxSaturation),
                100);

        /// <summary>
        /// Defines the <see cref="MaxValue"/> property.
        /// </summary>
        public static readonly StyledProperty<int> MaxValueProperty =
            AvaloniaProperty.Register<ColorView, int>(
                nameof(MaxValue),
                100);

        /// <summary>
        /// Defines the <see cref="MinHue"/> property.
        /// </summary>
        public static readonly StyledProperty<int> MinHueProperty =
            AvaloniaProperty.Register<ColorView, int>(
                nameof(MinHue),
                0);

        /// <summary>
        /// Defines the <see cref="MinSaturation"/> property.
        /// </summary>
        public static readonly StyledProperty<int> MinSaturationProperty =
            AvaloniaProperty.Register<ColorView, int>(
                nameof(MinSaturation),
                0);

        /// <summary>
        /// Defines the <see cref="MinValue"/> property.
        /// </summary>
        public static readonly StyledProperty<int> MinValueProperty =
            AvaloniaProperty.Register<ColorView, int>(
                nameof(MinValue),
                0);

        /// <summary>
        /// Defines the <see cref="ShowAccentColors"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> ShowAccentColorsProperty =
            AvaloniaProperty.Register<ColorView, bool>(
                nameof(ShowAccentColors),
                true);

        /// <inheritdoc cref="ColorSpectrum.Color"/>
        public Color Color
        {
            get => GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        /// <inheritdoc cref="ColorSlider.ColorModel"/>
        /// <remarks>
        /// This property is only applicable to the components tab.
        /// The spectrum tab must always be in HSV and the palette tab is pre-defined colors.
        /// </remarks>
        public ColorModel ColorModel
        {
            get => GetValue(ColorModelProperty);
            set => SetValue(ColorModelProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.Components"/>
        public ColorSpectrumComponents ColorSpectrumComponents
        {
            get => GetValue(ColorSpectrumComponentsProperty);
            set => SetValue(ColorSpectrumComponentsProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.Shape"/>
        public ColorSpectrumShape ColorSpectrumShape
        {
            get => GetValue(ColorSpectrumShapeProperty);
            set => SetValue(ColorSpectrumShapeProperty, value);
        }

        /// <summary>
        /// Gets the list of custom palette colors.
        /// </summary>
        public ObservableCollection<Color> CustomPaletteColors
        {
            get => _customPaletteColors;
        }

        /// <summary>
        /// Gets or sets the number of colors in each row (section) of the custom color palette.
        /// Within a standard palette, rows are shades and columns are colors.
        /// </summary>
        public int CustomPaletteColumnCount
        {
            get => GetValue(CustomPaletteColumnCountProperty);
            set => SetValue(CustomPaletteColumnCountProperty, value);
        }

        /// <summary>
        /// Gets or sets the custom color palette.
        /// This will automatically set <see cref="CustomPaletteColors"/> and <see cref="CustomPaletteColumnCount"/>
        /// overwriting any existing values.
        /// </summary>
        public IColorPalette? CustomPalette
        {
            get => GetValue(CustomPaletteProperty);
            set => SetValue(CustomPaletteProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.HsvColor"/>
        public HsvColor HsvColor
        {
            get => GetValue(HsvColorProperty);
            set => SetValue(HsvColorProperty, value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the alpha component is enabled.
        /// When disabled (set to false) the alpha component will be fixed to maximum.
        /// </summary>
        public bool IsAlphaEnabled
        {
            get => GetValue(IsAlphaEnabledProperty);
            set => SetValue(IsAlphaEnabledProperty, value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the alpha component editing controls
        /// (both Slider and TextBox) are visible.
        /// </summary>
        /// <remarks>
        /// Note that <see cref="IsComponentTextInputVisible"/> also controls the alpha
        /// component TextBox visibility.
        /// </remarks>
        public bool IsAlphaVisible
        {
            get => GetValue(IsAlphaVisibleProperty);
            set => SetValue(IsAlphaVisibleProperty, value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the color palette is visible.
        /// </summary>
        public bool IsColorPaletteVisible
        {
            get => GetValue(IsColorPaletteVisibleProperty);
            set => SetValue(IsColorPaletteVisibleProperty, value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the color preview is visible.
        /// </summary>
        /// <remarks>
        /// Note that accent color visibility is controlled separately by
        /// <see cref="ShowAccentColors"/>.
        /// </remarks>
        public bool IsColorPreviewVisible
        {
            get => GetValue(IsColorPreviewVisibleProperty);
            set => SetValue(IsColorPreviewVisibleProperty, value);
        }

        // IsColorComponentsVisible

        public bool IsColorSliderVisible // ColorSpectrumSlider
        {
            get => GetValue(IsColorSliderVisibleProperty);
            set => SetValue(IsColorSliderVisibleProperty, value);
        }

        public bool IsColorSpectrumVisible
        {
            get => GetValue(IsColorSpectrumVisibleProperty);
            set => SetValue(IsColorSpectrumVisibleProperty, value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether color component text inputs are visible.
        /// </summary>
        /// <remarks>
        /// All color components are controlled by this property but alpha can also be
        /// controlled with <see cref="IsAlphaVisible"/>.
        /// </remarks>
        public bool IsComponentTextInputVisible
        {
            get => GetValue(IsComponentTextInputVisibleProperty);
            set => SetValue(IsComponentTextInputVisibleProperty, value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the hexadecimal color value text input
        /// is visible.
        /// </summary>
        public bool IsHexInputVisible
        {
            get => GetValue(IsHexInputVisibleProperty);
            set => SetValue(IsHexInputVisibleProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.MaxHue"/>
        public int MaxHue
        {
            get => GetValue(MaxHueProperty);
            set => SetValue(MaxHueProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.MaxSaturation"/>
        public int MaxSaturation
        {
            get => GetValue(MaxSaturationProperty);
            set => SetValue(MaxSaturationProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.MaxValue"/>
        public int MaxValue
        {
            get => GetValue(MaxValueProperty);
            set => SetValue(MaxValueProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.MinHue"/>
        public int MinHue
        {
            get => GetValue(MinHueProperty);
            set => SetValue(MinHueProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.MinSaturation"/>
        public int MinSaturation
        {
            get => GetValue(MinSaturationProperty);
            set => SetValue(MinSaturationProperty, value);
        }

        /// <inheritdoc cref="ColorSpectrum.MinValue"/>
        public int MinValue
        {
            get => GetValue(MinValueProperty);
            set => SetValue(MinValueProperty, value);
        }

        /// <inheritdoc cref="ColorPreviewer.ShowAccentColors"/>
        public bool ShowAccentColors
        {
            get => GetValue(ShowAccentColorsProperty);
            set => SetValue(ShowAccentColorsProperty, value);
        }
    }
}
