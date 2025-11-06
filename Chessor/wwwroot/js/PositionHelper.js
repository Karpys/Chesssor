window.chessHelper = {
    getElementPositionRef: function (el) {
        if (!el) return null;
        const rect = el.getBoundingClientRect();
        return {
            x: rect.left + window.scrollX,
            y: rect.top + window.scrollY,
            width: rect.width,
            height: rect.height
        };
    },

    initializeMouseMove: function (dotnetHelper) {
        document.addEventListener('mousemove', (e) => {
            dotnetHelper.invokeMethodAsync('OnGlobalMouseMove', e.clientX, e.clientY);
        });
    }
};