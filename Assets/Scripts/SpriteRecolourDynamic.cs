﻿using UnityEngine;
using System.Collections;


// You wouldn't normall use ExecuteInEditMode, I"m just doing this to make
// it appear in the editor
[ExecuteInEditMode]
public class SpriteRecolourDynamic : MonoBehaviour {

	public Color[] palette = new Color[] {
		new Color(0, 0, 0, 1),
		new Color(0.0392156862745098f, 0.023529411764705882f, 0.01568627450980392f, 1),
		new Color(0.0784313725490196f, 0.047058823529411764f, 0.03529411764705882f, 1),
		new Color(0.13333333333333333f, 0.09019607843137255f, 0.07450980392156863f, 1),
		new Color(0.1568627450980392f, 0.1411764705882353f, 0.10196078431372549f, 1),
		new Color(0.16470588235294117f, 0.16470588235294117f, 0.16470588235294117f, 1),
		new Color(0.09019607843137255f, 0.15294117647058825f, 0.20392156862745098f, 1),
		new Color(0.13725490196078433f, 0.21176470588235294f, 0.16470588235294117f, 1),
		new Color(0.22745098039215686f, 0.21568627450980393f, 0.15294117647058825f, 1),
		new Color(0.20784313725490197f, 0.13333333333333333f, 0.09411764705882353f, 1),
		new Color(0.3411764705882353f, 0.2196078431372549f, 0.13333333333333333f, 1),
		new Color(0.48627450980392156f, 0.43529411764705883f, 0.24313725490196078f, 1),
		new Color(0.4980392156862745f, 0.4588235294117647f, 0.3215686274509804f, 1),
		new Color(0.5803921568627451f, 0.5411764705882353f, 0.3764705882352941f, 1),
		new Color(0.7019607843137254f, 0.6509803921568628f, 0.4745098039215686f, 1),
		new Color(0.8196078431372549f, 0.7647058823529411f, 0.5450980392156862f, 1),
		new Color(0.803921568627451f, 0.7647058823529411f, 0.6313725490196078f, 1),
		new Color(0.788235294117647f, 0.788235294117647f, 0.788235294117647f, 1),
		new Color(1, 1, 1, 1),
		new Color(0.5019607843137255f, 0.5019607843137255f, 0.5019607843137255f, 1),
		new Color(0.09803921568627451f, 0.32941176470588235f, 0.11372549019607843f, 1),
		new Color(0.03529411764705882f, 0.19607843137254902f, 0.043137254901960784f, 1),
		new Color(0.01568627450980392f, 0.08235294117647059f, 0.023529411764705882f, 1),
		new Color(0.13333333333333333f, 0.5098039215686274f, 0.21176470588235294f, 1),
		new Color(0.2235294117647059f, 0.6666666666666666f, 0.3058823529411765f, 1),
		new Color(0.14901960784313725f, 0.6862745098039216f, 0.3254901960784314f, 1),
		new Color(0.3254901960784314f, 0.7490196078431373f, 0.44313725490196076f, 1),
		new Color(0.984313725490196f, 0.9450980392156862f, 0.25098039215686274f, 1),
	};

	private Color[] defaultPalette = new Color[] {
		new Color(0, 0, 0, 1),
		new Color(0.0392156862745098f, 0.023529411764705882f, 0.01568627450980392f, 1),
		new Color(0.0784313725490196f, 0.047058823529411764f, 0.03529411764705882f, 1),
		new Color(0.13333333333333333f, 0.09019607843137255f, 0.07450980392156863f, 1),
		new Color(0.1568627450980392f, 0.1411764705882353f, 0.10196078431372549f, 1),
		new Color(0.16470588235294117f, 0.16470588235294117f, 0.16470588235294117f, 1),
		new Color(0.09019607843137255f, 0.15294117647058825f, 0.20392156862745098f, 1),
		new Color(0.13725490196078433f, 0.21176470588235294f, 0.16470588235294117f, 1),
		new Color(0.22745098039215686f, 0.21568627450980393f, 0.15294117647058825f, 1),
		new Color(0.20784313725490197f, 0.13333333333333333f, 0.09411764705882353f, 1),
		new Color(0.3411764705882353f, 0.2196078431372549f, 0.13333333333333333f, 1),
		new Color(0.48627450980392156f, 0.43529411764705883f, 0.24313725490196078f, 1),
		new Color(0.4980392156862745f, 0.4588235294117647f, 0.3215686274509804f, 1),
		new Color(0.5803921568627451f, 0.5411764705882353f, 0.3764705882352941f, 1),
		new Color(0.7019607843137254f, 0.6509803921568628f, 0.4745098039215686f, 1),
		new Color(0.8196078431372549f, 0.7647058823529411f, 0.5450980392156862f, 1),
		new Color(0.803921568627451f, 0.7647058823529411f, 0.6313725490196078f, 1),
		new Color(0.788235294117647f, 0.788235294117647f, 0.788235294117647f, 1),
		new Color(1, 1, 1, 1),
		new Color(0.5019607843137255f, 0.5019607843137255f, 0.5019607843137255f, 1),
		new Color(0.09803921568627451f, 0.32941176470588235f, 0.11372549019607843f, 1),
		new Color(0.03529411764705882f, 0.19607843137254902f, 0.043137254901960784f, 1),
		new Color(0.01568627450980392f, 0.08235294117647059f, 0.023529411764705882f, 1),
		new Color(0.13333333333333333f, 0.5098039215686274f, 0.21176470588235294f, 1),
		new Color(0.2235294117647059f, 0.6666666666666666f, 0.3058823529411765f, 1),
		new Color(0.14901960784313725f, 0.6862745098039216f, 0.3254901960784314f, 1),
		new Color(0.3254901960784314f, 0.7490196078431373f, 0.44313725490196076f, 1),
		new Color(0.984313725490196f, 0.9450980392156862f, 0.25098039215686274f, 1),
	};

	SpriteRenderer spriteRenderer;
	float tDirection;
	float t;
	Color[] tempPalette;

	void UpdateColours() {
		if (spriteRenderer == null) {
			spriteRenderer = GetComponent<SpriteRenderer>();
		}
		// Lerp between default palette and customised
		Color[] newPalette;
		if (Mathf.Approximately(t, 0.0f)) {
			newPalette = defaultPalette;
		} else if (Mathf.Approximately(t, 1.0f)) {
			newPalette = palette;
		} else {
			for (int i = 0; i < tempPalette.Length; ++i) {
				tempPalette[i] = Color.Lerp(defaultPalette[i], palette[i], t);
			}
			newPalette = tempPalette;
		}
		Material mat = spriteRenderer.sharedMaterial;
		mat.SetColorArray("paletteData", newPalette);
	}

	void Awake() {
		tDirection = 1.0f;
		tempPalette = new Color[defaultPalette.Length];
		UpdateColours();

	}
	void Update() {
		t += Time.deltaTime * tDirection;
		if (t < 0.0f) {
			t = 0.0f;
			tDirection = 1.0f;
		} else if (t > 1.0f) {
			t = 1.0f;
			tDirection = -1.0f;
		}
		UpdateColours();
	}
}
