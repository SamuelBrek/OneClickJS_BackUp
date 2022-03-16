function CustomConfirm(titulo, mensaje, tipo) {
    return new Promise((resolve) => {
        Swal.fire({
            title: titulo,
            text: mensaje,
            icon: tipo,

            background: 'linear-gradient(315deg, #ff7878 0%, #74d680 74%)',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Confirmar',
            cancelButtonText: 'Cancelar'
        }).then((result) => {
            if (result.value) {
                resolve(true);
            } else {
                resolve(false);
            }
        })
    });
}

function CustomSave(titulo, icono) {
    Swal.fire({
        position: 'center',
        icon: icono,
        background: 'linear-gradient(315deg, #ff7878 0%, #74d680 74%)',
        title: titulo,
        showConfirmButton: false,
        timer: 1500
    })
}

function OpenNewTab(pdfName) {
    window.open('/pdf/' + pdfName);
}
function UploadedImage(imagenSubida) {
    Swal.fire({
        background: 'linear-gradient(315deg, #ff7878 0%, #74d680 74%)',
        title: 'Has cambiado de imagen!',
        text: 'Se ha removido la presente imagen',
        imageUrl: imagenSubida,
        imageAlt: 'Imagen actualizada',
    })
}
function SignUpSuccessfully(title) {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 3000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'success',
        title: title
    })
}
