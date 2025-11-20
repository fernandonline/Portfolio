window.lazySection = {
    observe: function (element, dotNetRef) {
        const observer = new IntersectionObserver(entries => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    dotNetRef.invokeMethodAsync("OnVisible");
                    observer.unobserve(entry.target);
                }
            })
        })
        observer.observe(element);
    }
}