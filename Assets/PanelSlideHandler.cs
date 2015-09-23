using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/// <summary>
/// パネルのスライドイン/アウトを制御するスクリプト
/// イベントをハンドルしてスライドイン・アウトを制御する
/// </summary>
[RequireComponent(typeof(Animator))]
public class PanelSlideHandler : MonoBehaviour, IPointerClickHandler
{
    /// <summary>パネルに追加されたAnimatorコンポーネント</summary>
    private Animator m_anim;

    void Start()
    {
        m_anim = GetComponent<Animator>();  // 初期化
    }

    /// <summary>
    /// パネルが引っ込んでいる状態の時はスライドアウトし、出ている状態の時は引っ込める
    /// </summary>
    void SlideInOut()
    {
        bool bIn = m_anim.GetBool("IsSlideIn"); // ハードコード
        m_anim.SetBool("IsSlideIn", !bIn);  // 現在の値とは逆の値をセットしてアニメーションを遷移させる
    }

    /// <summary>
    /// クリックイベント ハンドラー
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerClick(PointerEventData eventData)
    {
        SlideInOut();
    }
}
