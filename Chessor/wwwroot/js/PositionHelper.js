window.domHelper = {
    getElementPositionRef: function (el) {
        if (!el) return null;
        const rect = el.getBoundingClientRect();
        return {
            x: rect.left + window.scrollX,
            y: rect.top + window.scrollY,
            width: rect.width,
            height: rect.height
        };
    }
};